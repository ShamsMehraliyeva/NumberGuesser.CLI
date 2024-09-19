namespace NumberGuesser.CLI;

public record GameSettings(int LowerBound, int UpperBound, int MaxAttempts);
public record AdvancedGameSettings(int LowerBound, int UpperBound, int MaxAttempts, int DifficultyLevel) : GameSettings(LowerBound, UpperBound, MaxAttempts);