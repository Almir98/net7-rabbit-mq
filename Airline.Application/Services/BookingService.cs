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

        public async Task<BookingDTO> Create(BookingDTO model)
        {
            var entity = _mapper.Map<Booking>(model);

            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<BookingDTO>(entity);
        }
    }
}
