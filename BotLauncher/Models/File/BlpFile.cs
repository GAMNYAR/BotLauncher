namespace BotLauncher.Models.File;

public class BlpFile
{
    /// <summary>
    /// Сигнатура нашего формата.
    /// Позволяет программе понять,
    /// что файл действительно является .blp.
    /// </summary>
    public string Magic { get; set; } = "BLP1";

    /// <summary>
    /// Версия формата контейнера.
    /// </summary>
    public int Version { get; set; } = 1;

    /// <summary>
    /// Соль для PBKDF2.
    /// Хранится открыто.
    /// </summary>
    public string Salt { get; set; } = string.Empty;

    /// <summary>
    /// Nonce для AES-GCM.
    /// Хранится открыто.
    /// </summary>
    public string Nonce { get; set; } = string.Empty;

    /// <summary>
    /// Authentication Tag AES-GCM.
    /// </summary>
    public string Tag { get; set; } = string.Empty;

    /// <summary>
    /// Зашифрованные данные профиля.
    /// </summary>
    public string Ciphertext { get; set; } = string.Empty;
}