namespace Airline.Infrastructure.Interface;

public interface IMessageProducer
{
    void SendMessage<T>(T message);
}