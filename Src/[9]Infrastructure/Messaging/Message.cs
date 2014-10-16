
namespace Infrastructure.Messaging
{
    using System;
    using System.ComponentModel;

    public abstract class Message<T>
        where T : class
    {
        public Message()
        {
            this.Key = Guid.NewGuid();
            this.CreateDate = DateTime.UtcNow;
        }


        public Guid Key { get; private set; }

        public DateTime CreateDate { get; private set; }

        public Guid TargetKey { get; protected set; }

        public T Content { get; protected set; }
    }
}
