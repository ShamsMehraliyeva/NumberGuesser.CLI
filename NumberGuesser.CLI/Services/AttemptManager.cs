using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI.Services;

// Конкретная реализация интерфейса IAttemptManager
public class AttemptManager : IAttemptManager
{
    private int _attempts;
    private readonly int _maxAttempts;

    public AttemptManager(int maxAttempts)
    {
        _maxAttempts = maxAttempts;
    }

    public bool CanAttempt()
    {
        return _attempts < _maxAttempts;
    }

    public void IncrementAttempts()
    {
        _attempts++;
    }
}
