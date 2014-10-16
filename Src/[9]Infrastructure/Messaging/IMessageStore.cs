
namespace Infrastructure.Messaging
{
    using System;
    using System.Collections.Generic;
    
    public interface IMessageStore
    {
        IEnumerable<Message> GetMessages(Guid entityId);

        void StoreMessage(Message message);
    }
}
