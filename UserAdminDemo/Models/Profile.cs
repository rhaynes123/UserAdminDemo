using System;
using Microsoft.AspNetCore.Identity;

namespace UserAdminDemo.Models
{
    public class Profile : IdentityUser
    {
        public Role Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
