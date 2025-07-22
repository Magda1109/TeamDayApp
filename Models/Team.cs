namespace TeamDayApp.Models;

public class Team
{
    public string Name { get; set; } = string.Empty;
    public List<Member> Members { get; set; } = new();
}