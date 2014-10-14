
namespace Infrastructure.Messaging
{
    using System;

    public abstract class Message
    {
        public Message()
        {
            this.Key = Guid.NewGuid();
            this.CreateDate = DateTime.UtcNow;
        }


        public Guid Key { get; private set; }

        public DateTime CreateDate { get; private set; }
    }
}
