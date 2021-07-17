using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserAdminDemo.Models;

namespace UserAdminDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Profile> Profiles { get; set; }

        public bool UpdateRole(Profile profile)
        {
            try
            {
                Database.ExecuteSqlRaw($"Update AspNetUsers Set Role = {(int)profile.Role} WHERE Id = '{profile.Id}' ");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
