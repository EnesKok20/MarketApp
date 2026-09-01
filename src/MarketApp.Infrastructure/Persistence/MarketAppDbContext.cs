using Microsoft.EntityFrameworkCore;

namespace MarketApp.Infrastructure.Persistence;

public class MarketAppDbContext : DbContext
{
    public MarketAppDbContext(DbContextOptions<MarketAppDbContext> options) : base(options)
    {
    }
}