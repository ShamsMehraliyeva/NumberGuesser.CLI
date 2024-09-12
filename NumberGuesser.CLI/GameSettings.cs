namespace NumberGuesser.CLI;

public record GameSettings
{
    public int LowerBound { get; set; }
    public int UpperBound { get; set; }
    public int MaxAttempts { get; set; }
}