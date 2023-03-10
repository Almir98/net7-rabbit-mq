namespace Airline.Infrastructure.Implementation
{
    public class MessageProducer : IMessageProducer
    {
        public void SendMessage<T>(T message)
        {
            if (message == null)
                throw new ArgumentNullException("message is null");

            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "admin",
                Password = "password",
                VirtualHost = "/"
            };

            var connection = connectionFactory.CreateConnection();

            using var channel = connection.CreateModel();

            channel.QueueDeclare("bookings", durable: true, exclusive: true);

            //var jsonString = JsonSerializer.Serialize(message);

            var jsonString = "";

            var body = Encoding.UTF8.GetBytes(jsonString);

            channel.BasicPublish("","bookings",body: body);
        }
    }
}