namespace Application.PreFlightChecks;

public class PreFlightCheckResult
{
    public bool Passed { get; set; } = true;
    public List<string> Issues { get; } = new();
}