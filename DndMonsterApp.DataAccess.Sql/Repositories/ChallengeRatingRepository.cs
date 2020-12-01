using DndMonsterApp.DataAccess.Sql.Contexts;
using DndMonsterApp.DataAccess.Sql.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndMonsterApp.DataAccess.Sql.Repositories
{
    public class ChallengeRatingRepository : IChallengeRatingRepository
    {
        private readonly MonsterAppDbContext context;

        public ChallengeRatingRepository(MonsterAppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<ChallengeRating>> GetAllAsync()
        {
            return await context.ChallengeRatings.OrderBy(cr => cr.Id).ToListAsync();
        }
    }
}
