using Microsoft.EntityFrameworkCore;
using HittaHem.Models;

namespace HittaHem.Data;

public class HittaHemDbContext : DbContext
{
    public HittaHemDbContext(DbContextOptions<HittaHemDbContext> options)
        : base(options)
    {
    }

    public DbSet<Dog> Dogs { get; set; }
}
