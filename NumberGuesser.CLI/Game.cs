using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI;

// Основной класс игры
public class Game
{
    private readonly GameSettings _settings;
    private readonly NumberGenerator _numberGenerator;
    private readonly IUserInput _userInput;
    private readonly IMessageProvider _messageProvider;
    private readonly IAttemptManager _attemptManager;
    private int _targetNumber;

    public Game(GameSettings settings, NumberGenerator numberGenerator, IUserInput userInput, IMessageProvider messageProvider, IAttemptManager attemptManager)
    {
        _settings = settings;
        _numberGenerator = numberGenerator;
        _userInput = userInput;
        _messageProvider = messageProvider;
        _attemptManager = attemptManager;
        _targetNumber = numberGenerator.GenerateNumber();
    }

    public void Play()
    {
        while (_attemptManager.CanAttempt())
        {
            int guess = _userInput.GetUserInput();
            if (guess < _targetNumber)
            {
                _messageProvider.DisplayMessage("Слишком маленькое число.");
            }
            else if (guess > _targetNumber)
            {
                _messageProvider.DisplayMessage("Слишком большое число.");
            }
            else
            {
                _messageProvider.DisplayMessage("Поздравляем! Вы угадали число.");
                return;
            }
            _attemptManager.IncrementAttempts();
        }
        _messageProvider.DisplayMessage($"Вы исчерпали все попытки. Правильное число было: {_targetNumber}");
    }
}
