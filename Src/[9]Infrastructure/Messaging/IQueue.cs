
namespace Infrastructure.Messaging
{
    public interface IQueue
    {
        void Publish(Message message);

        void Subscribe<T>(IMessageHandle subscriber) where T : Message;

    }
}
