using System.Data.Entity;
using RoadBook.CsharpBasic.Chapter08.Model;

namespace RoadBook.CsharpBasic.Chapter08.Data
{
    public class UserContext : DbContext
    {
        public UserContext() : base("SQLiteDb")
        {
        }
        
        public DbSet<User> Users { get; set; }
    }
}