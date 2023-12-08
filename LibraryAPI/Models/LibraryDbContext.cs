using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id= 1, Title="Book 1", Description ="Description 1", Author="Auther 1", Rating=3.7,CoverUrl="https://www.example.com" },
                new Book { Id= 2, Title="Book 2", Description ="Description 2", Author="Auther 2", Rating=5,CoverUrl="https://www.example.com" },
                new Book { Id= 3, Title="Book 3", Description ="Description 3", Author="Auther 3", Rating=2.4,CoverUrl="https://www.example.com" },
                new Book { Id= 4, Title="Book 4", Description ="Description 4", Author="Auther 4", Rating=0.7,CoverUrl="https://www.example.com" }
                
                
                );
        }
    }
}
