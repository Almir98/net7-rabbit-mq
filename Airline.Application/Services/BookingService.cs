namespace Airline.Application.Services
{
    public class BookingService : IBooking
    {
        private readonly IMapper _mapper;
        private readonly AirlineContext _dbContext;

        public BookingService(AirlineContext airlineContext, IMapper mapper)
        {
            _dbContext = airlineContext;
            _mapper = mapper;
        }

        public BookingDTO Create(BookingDTO model)
        {
            var entity = _mapper.Map<Booking>(model);

            _dbContext.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<BookingDTO>(entity);
        }
    }
}
