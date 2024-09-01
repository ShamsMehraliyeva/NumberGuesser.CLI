namespace NumberGuesser.CLI;

public class NumberGenerator
{
    private readonly int _lowerBound;
    private readonly int _upperBound;
    private readonly Random _random;

    public NumberGenerator(int lowerBound, int upperBound)
    {
        _lowerBound = lowerBound;
        _upperBound = upperBound;
        _random = new Random();
    }

    public int GenerateNumber()
    {
        return _random.Next(_lowerBound, _upperBound + 1);
    }
}