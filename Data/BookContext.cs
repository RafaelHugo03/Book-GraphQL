using GraphQL_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Project.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookContext(DbContextOptions options) : base(options)
        {
        }
    }
}