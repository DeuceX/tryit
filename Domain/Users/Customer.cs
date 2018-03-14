using System;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Domain.Users
{
    [JsonObject(IsReference = true)]
    public class Customer : IdentityUser<int>
    {
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string Description { get; set; }
        public string AvatarUrl { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public DateTime? DateOfBirthsday { get; set; }

        public string Country { get; set; }

        public string Language { get; set; }
    }
}
