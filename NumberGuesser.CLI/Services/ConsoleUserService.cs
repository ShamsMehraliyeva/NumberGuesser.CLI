using NumberGuesser.CLI.Interfaces;

namespace NumberGuesser.CLI.Services;

// Класс для получения ввода и отображения сообщений
public class ConsoleUserService: IUserInput
{
    public int GetUserInput()
    {
        Console.Write("Введите число: ");
        return int.Parse(Console.ReadLine());
    }
}