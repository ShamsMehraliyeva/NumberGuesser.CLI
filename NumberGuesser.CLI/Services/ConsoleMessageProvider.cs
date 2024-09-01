using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI.Services;

// Конкретная реализация интерфейса IMessageProvider для консольного вывода
public class ConsoleMessageProvider:IMessageProvider
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}