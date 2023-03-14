namespace Airline.Application.Interfaces;

public interface IBooking
{
    Task<BookingDTO> Create(BookingDTO model);
}