﻿using NumberGuesser.CLI.Services;

namespace NumberGuesser.CLI;

class Program
{
    static void Main(string[] args)
    {
        // Настройки игры
        var settings = new GameSettings(1, 100, 10);

        // Генератор чисел
        var numberGenerator = new NumberGenerator(lowerBound: settings.LowerBound, upperBound: settings.UpperBound);

        // Интерфейс для ввода пользователя
        var userInput = new ConsoleUserService(); // Реализация интерфейса IUserInput

        // Провайдер сообщений
        var messageProvider = new ConsoleMessageProvider(); // Реализация интерфейса IMessageProvider

        // Менеджер попыток
        var attemptManager = new AttemptManager(maxAttempts: settings.MaxAttempts);

        // Игра
        var game = new Game(numberGenerator, userInput, messageProvider, attemptManager);

        // Запуск игры
        game.Play();
    }
}