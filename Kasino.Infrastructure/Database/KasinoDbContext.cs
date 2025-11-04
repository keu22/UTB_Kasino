using Kasino.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kasino.Infrastructure.Database
{
    public class KasinoDbContext : DbContext
    {
        public DbSet<Bet> Bets { get; set; }
        public DbSet<BetResult> BetResults { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        public KasinoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

    }
}
