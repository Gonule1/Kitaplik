using Kitaplik.Models;
using Microsoft.EntityFrameworkCore;

namespace Kitaplik.Repository;

public class RepositoryBaglantisi : DbContext
{
    public RepositoryBaglantisi (DbContextOptions options) : base (options)
    {


    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=Kitaplik_db;Trusted_Connection=true");
    }
    public DbSet<Book> Books { get; set; }

}

