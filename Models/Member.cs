namespace TeamDayApp.Models;

public class Member
{
    public string Name { get; set; } = string.Empty;
    public Dictionary<DateOnly, AvailabilityOption> Availability { get; set; } = new();
}