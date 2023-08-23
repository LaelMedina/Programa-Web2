using Microsoft.EntityFrameworkCore;
using programs.Models;

namespace programs.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :
    base(options)
    { }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Song> Songs { get; set; }

}