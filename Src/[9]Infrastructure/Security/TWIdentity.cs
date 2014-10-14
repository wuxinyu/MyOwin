
namespace Infrastructure.Security
{
    using System.Security.Principal;

    public abstract class TWIdentity : IIdentity
    {
        public string Name { get; private set; }

        public string AuthenticationType { get; private set; }

        public bool IsAuthenticated { get; private set; }
    }
}