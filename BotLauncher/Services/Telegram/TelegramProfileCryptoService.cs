using System.Security.Cryptography;
using System.Text;

namespace BotLauncher.Services.Telegram;

public class TelegramProfileCryptoService
{
    private const int SaltSize = 16;
    private const int NonceSize = 12;
    private const int KeySize = 32;
    private const int TagSize = 16;

    // Начальное значение.
    // В дальнейшем при необходимости можно увеличить
    // количество итераций и сделать версионирование формата.
    private const int Pbkdf2Iterations = 600_000;

    private static readonly byte[] Magic =
        Encoding.ASCII.GetBytes("BLP1");

    /// <summary>
    /// Зашифровать данные профиля паролем.
    /// </summary>
    public byte[] Encrypt(
        string password,
        byte[] plainData)
    {
        ValidatePassword(password);

        if (plainData == null)
            throw new ArgumentNullException(
                nameof(plainData));

        byte[] salt =
            RandomNumberGenerator.GetBytes(
                SaltSize);

        byte[] nonce =
            RandomNumberGenerator.GetBytes(
                NonceSize);

        byte[] key =
            DeriveKey(
                password,
                salt);

        byte[] cipherText =
            new byte[plainData.Length];

        byte[] tag =
            new byte[TagSize];

        try
        {
            using AesGcm aes =
                new AesGcm(
                    key,
                    TagSize);

            aes.Encrypt(
                nonce,
                plainData,
                cipherText,
                tag,
                Magic);

            using MemoryStream stream =
                new MemoryStream();

            using BinaryWriter writer =
                new BinaryWriter(stream);

            // =====================================================
            // Заголовок
            // =====================================================

            writer.Write(Magic);

            // Версия формата
            writer.Write(
                (byte)1);

            // Размер соли
            writer.Write(
                (byte)SaltSize);

            // Размер nonce
            writer.Write(
                (byte)NonceSize);

            // Размер authentication tag
            writer.Write(
                (byte)TagSize);

            // Количество итераций PBKDF2
            writer.Write(
                Pbkdf2Iterations);

            // =====================================================
            // Криптографические данные
            // =====================================================

            writer.Write(salt);
            writer.Write(nonce);
            writer.Write(tag);

            // =====================================================
            // Зашифрованный профиль
            // =====================================================

            writer.Write(
                cipherText.Length);

            writer.Write(
                cipherText);

            writer.Flush();

            return stream.ToArray();
        }
        finally
        {
            CryptographicOperations.ZeroMemory(
                key);
        }
    }

    /// <summary>
    /// Расшифровать профиль.
    ///
    /// Если пароль неправильный или файл повреждён,
    /// будет выброшено CryptographicException.
    /// </summary>
    public byte[] Decrypt(
        string password,
        byte[] encryptedData)
    {
        ValidatePassword(password);

        if (encryptedData == null)
            throw new ArgumentNullException(
                nameof(encryptedData));

        try
        {
            using MemoryStream stream =
                new MemoryStream(
                    encryptedData);

            using BinaryReader reader =
                new BinaryReader(stream);

            // =====================================================
            // Проверяем заголовок
            // =====================================================

            byte[] magic =
                reader.ReadBytes(
                    Magic.Length);

            if (!magic.SequenceEqual(Magic))
            {
                throw new CryptographicException(
                    "Файл не является профилем BotLauncher.");
            }

            byte version =
                reader.ReadByte();

            if (version != 1)
            {
                throw new CryptographicException(
                    $"Неподдерживаемая версия профиля: {version}.");
            }

            int saltSize =
                reader.ReadByte();

            int nonceSize =
                reader.ReadByte();

            int tagSize =
                reader.ReadByte();

            int iterations =
                reader.ReadInt32();

            // =====================================================
            // Проверяем параметры
            // =====================================================

            if (saltSize < 16 ||
                saltSize > 64)
            {
                throw new CryptographicException(
                    "Некорректный размер соли.");
            }

            if (nonceSize != NonceSize)
            {
                throw new CryptographicException(
                    "Некорректный размер nonce.");
            }

            if (tagSize != TagSize)
            {
                throw new CryptographicException(
                    "Некорректный размер authentication tag.");
            }

            if (iterations < 100_000 ||
                iterations > 10_000_000)
            {
                throw new CryptographicException(
                    "Некорректный параметр PBKDF2.");
            }

            // =====================================================
            // Читаем криптографические данные
            // =====================================================

            byte[] salt =
                reader.ReadBytes(
                    saltSize);

            byte[] nonce =
                reader.ReadBytes(
                    nonceSize);

            byte[] tag =
                reader.ReadBytes(
                    tagSize);

            if (salt.Length != saltSize ||
                nonce.Length != nonceSize ||
                tag.Length != tagSize)
            {
                throw new CryptographicException(
                    "Файл профиля повреждён.");
            }

            int cipherTextLength =
                reader.ReadInt32();

            if (cipherTextLength < 0 ||
                cipherTextLength >
                    stream.Length -
                    stream.Position)
            {
                throw new CryptographicException(
                    "Некорректный размер зашифрованных данных.");
            }

            byte[] cipherText =
                reader.ReadBytes(
                    cipherTextLength);

            if (cipherText.Length !=
                cipherTextLength)
            {
                throw new CryptographicException(
                    "Файл профиля повреждён.");
            }

            // Никаких лишних данных после профиля
            if (stream.Position != stream.Length)
            {
                throw new CryptographicException(
                    "Файл профиля содержит некорректные данные.");
            }

            // =====================================================
            // Получаем ключ из пароля
            // =====================================================

            byte[] key =
                Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256,
                    KeySize);

            byte[] plainData =
                new byte[cipherText.Length];

            try
            {
                using AesGcm aes =
                    new AesGcm(
                        key,
                        TagSize);

                aes.Decrypt(
                    nonce,
                    cipherText,
                    tag,
                    plainData,
                    Magic);

                return plainData;
            }
            catch (CryptographicException)
            {
                throw new CryptographicException(
                    "Неверный пароль или повреждённый профиль.");
            }
            finally
            {
                CryptographicOperations.ZeroMemory(
                    key);
            }
        }
        catch (EndOfStreamException)
        {
            throw new CryptographicException(
                "Файл профиля повреждён.");
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new CryptographicException(
                "Файл профиля содержит некорректные данные.");
        }
    }

    /// <summary>
    /// Проверить пароль.
    /// </summary>
    private static void ValidatePassword(
        string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException(
                "Пароль не может быть пустым.",
                nameof(password));
        }
    }

    /// <summary>
    /// Получить ключ шифрования из пароля.
    /// </summary>
    private static byte[] DeriveKey(
        string password,
        byte[] salt)
    {
        return Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            Pbkdf2Iterations,
            HashAlgorithmName.SHA256,
            KeySize);
    }
}