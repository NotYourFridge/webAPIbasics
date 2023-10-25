using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class SchoolContext : DbContext
{

    public SchoolContext(DbContextOptions o) : base(o)
    {

    }

    public DbSet<Student> studenten { get; set; }
    public DbSet<Docent> docenten { get; set; }


}