namespace Airline.API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Booking, BookingDTO>().ReverseMap();
        }
    }
}