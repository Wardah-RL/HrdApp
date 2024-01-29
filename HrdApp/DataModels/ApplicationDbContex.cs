using HrdApp.DataModels.Entity;
using Microsoft.EntityFrameworkCore;

namespace HrdApp.DataModels
{
  public class ApplicationDbContex : DbContext
  {
    public ApplicationDbContex(DbContextOptions<ApplicationDbContex>options) : base(options) 
    { 
    }

    public DbSet<Coba> cobas { get; set; }
  }
}
