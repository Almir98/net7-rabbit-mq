namespace Airline.Infrastructure.Entities;
public class Booking
{
    public int Id { get; set; }
    public string PassangerName { get; set; } = String.Empty;
    public string PassportNumber { get; set; } = String.Empty;
    public string From { get; set; } = String.Empty;
    public string To { get; set; } = String.Empty;
    public int Status { get; set; }
}