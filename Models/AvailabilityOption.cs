public enum AvailabilityOption
{
    Available,
    NotAvailable,
    IfNeeded
}

public static class AvailabilityOptionExtensions
{
    public static string GetDescription(this AvailabilityOption option)
    {
        return option switch
        {
            AvailabilityOption.Available => "Available",
            AvailabilityOption.NotAvailable => "Not Available",
            AvailabilityOption.IfNeeded => "Available if needed",
            _ => option.ToString()
        };
    }
}