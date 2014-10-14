
namespace Infrastructure.Security
{
    using System;
    using System.Security.Principal;

    public class TWPrincipal : IPrincipal
    {
        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }

        public IIdentity Identity { get; private set; }

    }
}
