namespace Airline.Models.DTOs;

public record BookingDTO
{
    public string PassangerName { get; init; } 
    public string PassportNumber { get; init; } 
    public string From { get; init; }
    public string To { get; init; }
    public int Status { get; init; }

}