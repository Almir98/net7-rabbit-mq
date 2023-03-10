using Airline.Application.Interfaces;

namespace Airline.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly ILogger<BookingController> _logger;
    private readonly IMessageProducer _messageProducer;
    private readonly IBooking _bookingService;
    
    public BookingController(ILogger<BookingController> logger, IMessageProducer messageProducer, IBooking bookingService)
    {
        _logger = logger;
        _messageProducer = messageProducer;
        _bookingService = bookingService;
    }

    [HttpPost]
    public IActionResult CreateBooking(BookingDTO model)
    {
        if (model is null)
            return BadRequest();

        _bookingService.Create(model);

        //_messageProducer.SendMessage(model);

        return Ok(model);
    }
}