using DndMonsterApp.DataAccess.Sql.Entities;
using Microsoft.EntityFrameworkCore;

namespace DndMonsterApp.DataAccess.Sql.Contexts
{
    public class MonsterAppDbContext : DbContext
    {
        public MonsterAppDbContext(DbContextOptions options) : base(options){ }

        public DbSet<ChallengeRating> ChallengeRatings { get; set; }
    }
}