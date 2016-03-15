using System.Data.Entity;
using TPFinal.Models;

namespace TPFinal

{
    public class Program
    {
         
    }

    public class TestifyContext : DbContext
    {
        public DbSet<User> users { get; set; }
    } 
}