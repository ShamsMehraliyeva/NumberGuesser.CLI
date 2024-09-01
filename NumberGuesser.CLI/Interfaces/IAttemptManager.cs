namespace NumberGuesser.CLI.Interfaces;

// Интерфейс для управления попытками
public interface IAttemptManager
{
    bool CanAttempt();
    void IncrementAttempts();
}