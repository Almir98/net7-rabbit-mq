namespace Airline.Infrastructure.Implementation;

public class MessageProducer : IMessageProducer
{
    public void SendMessage<T>(T message)
    {
        if (message == null)
            throw new ArgumentNullException("Message is null");

        var connectionFactory = new ConnectionFactory()
        {
            HostName = "localhost",
            UserName = "admin",
            Password = "password",
            VirtualHost = "/"
        };

        var connection = connectionFactory.CreateConnection();

        using var channel = connection.CreateModel();

        channel.QueueDeclare("bookings", durable: true, exclusive: false, false, null);

        var jsonString = JsonSerializer.Serialize(message);

        var body = Encoding.UTF8.GetBytes(jsonString);

        channel.BasicPublish("","bookings", body: body);
    }
}