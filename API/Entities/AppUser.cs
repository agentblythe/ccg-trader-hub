using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public string id { get; private set; } = string.Empty;

        public string UserName { get; private set; } = string.Empty;

        public byte[]? PasswordHash { get; private set; }

        public byte[]? PasswordSalt { get; private set; }
    }
}