using System;

namespace Soloco.RealTimeWeb.Membership.Users.Domain
{
    public class UserLogin
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserName { get; set; }
    }
}