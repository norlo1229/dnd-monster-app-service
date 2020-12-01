using DndMonsterApp.DataAccess.Sql.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DndMonsterApp.DataAccess.Sql.Repositories
{
    public interface IChallengeRatingRepository
    {
        Task<List<ChallengeRating>> GetAllAsync();
    }
}
