using System;

public class Player : IPlayable, IRecodable
{
    private string playState = "зупинено";
    private string recordState = "зупинено";

    public void Play()
    {
        playState = "відтворюється";
        Console.WriteLine("Програвання: відтворення запущено.");
    }

    public void Record()
    {
        recordState = "йде запис";
        Console.WriteLine("Запис: запис розпочато.");
    }

    // Pause() і Stop() є в обох інтерфейсах, тому реалізовані явно
    void IPlayable.Pause()
    {
        playState = "пауза";
        Console.WriteLine("Програвання: відтворення поставлено на паузу.");
    }

    void IPlayable.Stop()
    {
        playState = "зупинено";
        Console.WriteLine("Програвання: відтворення зупинено.");
    }

    void IRecodable.Pause()
    {
        recordState = "пауза";
        Console.WriteLine("Запис: запис поставлено на паузу.");
    }

    void IRecodable.Stop()
    {
        recordState = "зупинено";
        Console.WriteLine("Запис: запис зупинено, файл збережено.");
    }

    public void ShowState()
    {
        Console.WriteLine("  Стан -> програвання: " + playState + ", запис: " + recordState);
    }
}
