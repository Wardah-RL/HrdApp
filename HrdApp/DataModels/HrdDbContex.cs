using HrdApp.DataModels.Entity;
using Microsoft.EntityFrameworkCore;

namespace HrdApp.DataModels
{
  public class HrdDbContex : DbContext
  {
    public HrdDbContex(DbContextOptions<HrdDbContex>options) : base(options) 
    { 
    }

    public DbSet<Coba> cobas { get; set; }
  }
}
