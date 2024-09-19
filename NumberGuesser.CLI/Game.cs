using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI;

// Основной класс игры
public class Game
{
    private readonly IUserInput _userInput;
    private readonly IMessageProvider _messageProvider;
    private readonly IAttemptManager _attemptManager;
    private int _targetNumber;

    public Game(NumberGenerator numberGenerator, IUserInput userInput, IMessageProvider messageProvider, IAttemptManager attemptManager)
    {
        _userInput = userInput;
        _messageProvider = messageProvider;
        _attemptManager = attemptManager;
        _targetNumber = numberGenerator.GenerateNumber();
    }

    public void Play()
    {
        while (_attemptManager.CanAttempt())
        {
            int guess = int.Parse(_userInput.GetInput());
            if (guess < _targetNumber)
            {
                _messageProvider.SendMessage("Слишком маленькое число.");
            }
            else if (guess > _targetNumber)
            {
                _messageProvider.SendMessage("Слишком большое число.");
            }
            else
            {
                _messageProvider.SendMessage("Поздравляем! Вы угадали число.");
                return;
            }
            _attemptManager.IncrementAttempts();
        }
        _messageProvider.SendMessage($"Вы исчерпали все попытки. Правильное число было: {_targetNumber}");
    }
}
