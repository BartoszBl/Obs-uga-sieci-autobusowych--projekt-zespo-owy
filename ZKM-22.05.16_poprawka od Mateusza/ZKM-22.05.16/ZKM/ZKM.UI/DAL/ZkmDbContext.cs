using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ZKM.UI.Models;

namespace ZKM.UI.DAL
{
    public class ZkmDbContext : IdentityDbContext<ApplicationUser>
    {
        public static ZkmDbContext Create()
        {                        
            return new ZkmDbContext();
        }

        public ZkmDbContext() : base("DefaultConnection")
        {
            Database.Initialize(false);
        }

        public DbSet<Autobus> Autobusy { get; set;}

        public DbSet<Przystanek> Przystanki { get; set; }

        public DbSet<Kontrola> Kontrolas { get; set; }

        public DbSet<Naprawa> Naprawy { get; set; }

        public DbSet<Incydent> Incydenty { get; set; }
    }
}