using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public Guid Id { get; private set; } = Guid.Empty;

        public string UserName { get; private set; } = string.Empty;
    }
}