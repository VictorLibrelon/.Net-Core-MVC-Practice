using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)           
        {

        }

        public DbSet<ContactModel> Contacts { get; set; } 
    }
}