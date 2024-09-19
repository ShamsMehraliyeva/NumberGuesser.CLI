using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI.Services;

public class LogMessageProvider : IMessageProvider
{
    private readonly string _logFilePath;

    public LogMessageProvider(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public void SendMessage(string message)
    {
        File.AppendAllText(_logFilePath, message + Environment.NewLine);
    }
}