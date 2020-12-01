using AutoMapper;
using DndMonsterApp.DataAccess.Sql.Entities;
using DndMonsterApp.Models;

namespace DndMonsterApp.Api.DataMapping
{
    public class AutomapperTransforms : Profile
    {
        public AutomapperTransforms()
        {
            this.CreateMap<ChallengeRating, ChallengeRatingModel>().ReverseMap();
        }
    }
}
