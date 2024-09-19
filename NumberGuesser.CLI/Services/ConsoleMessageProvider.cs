using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI.Services;

// Конкретная реализация интерфейса IMessageProvider для консольного вывода
public class ConsoleMessageProvider : IMessageProvider, IUserInput
{
    public void SendMessage(string message) => Console.WriteLine(message);

    public string GetInput() => Console.ReadLine();
}