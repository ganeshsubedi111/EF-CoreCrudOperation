using Microsoft.EntityFrameworkCore;

namespace CrudEntityFramework.Models
{
    public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {

    }

    public DbSet<BookModel> Book { get; set; }
}
}
