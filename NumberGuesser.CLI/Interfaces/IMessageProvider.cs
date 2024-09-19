namespace NumberGuesser.CLI.Interfaces;

// Интерфейс для вывода сообщений
public interface IMessageProvider
{
    void SendMessage(string message);
}