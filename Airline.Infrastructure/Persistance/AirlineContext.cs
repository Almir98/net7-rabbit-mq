using Airline.Infrastructure.Entities;

namespace Airline.Infrastructure.Persistance;

public class AirlineContext : DbContext
{
    public AirlineContext() { }

    public AirlineContext(DbContextOptions<AirlineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RabbitDb;User Id=AlmirT;Password=11101998at.;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");
        }
    }
}