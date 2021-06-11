using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {

    }

    public DbSet<Business> Businesses { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
      .HasData(
        new Business { BusinessId = 1, Name = "Pho Than Brothers", Location = "4207 University Way NE" },
        new Business { BusinessId = 2, Name = "Outsider Comics and Geek Boutique", Location = "223 North 36th Street Seattle" },
        new Business { BusinessId = 3, Name = "Agora", Location = "346 15th Avenue East, Seattle" },
        new Business { BusinessId = 4, Name = "Likelihood", Location = "1101 East Union Street, Seattle" },
        new Business { BusinessId = 5, Name = "Clementines", Location = "310 Occidental Avenue South, Seattle" },
        new Business { BusinessId = 6, Name = "Thea Candle Co", Location = "Online" },
        new Business { BusinessId = 7, Name = "Ugly Baby Shop", Location = "1430 Western Avenue, Seattle" },
        new Business { BusinessId = 8, Name = "35th North", Location = "1100 E Pike Street, Seattle" }
      );
    }
  }
}