using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Data;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<Status> Statuses { get; set; }
    
}