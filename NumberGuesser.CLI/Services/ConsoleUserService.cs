using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI.Services;

// Класс для получения ввода и отображения сообщений
public class ConsoleUserService: IUserInput
{
    public string GetInput()
    {
        Console.Write("Введите число: ");
        return Console.ReadLine();
    }
}