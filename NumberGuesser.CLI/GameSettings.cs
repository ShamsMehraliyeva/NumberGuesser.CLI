namespace NumberGuesser.CLI;

public class GameSettings
{
    public int LowerBound { get; }
    public int UpperBound { get; }
    public int MaxAttempts { get; }
    
    public GameSettings(int lowerBound, int upperBound, int maxAttempts)
    {
        LowerBound = lowerBound;
        UpperBound = upperBound;
        MaxAttempts = maxAttempts;
    }
}