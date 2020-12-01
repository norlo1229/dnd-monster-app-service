using AutoMapper;
using DndMonsterApp.DataAccess.Sql.Entities;
using DndMonsterApp.DataAccess.Sql.Repositories;
using DndMonsterApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DndMonsterApp.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ChallengeRatingController : ControllerBase
    {
        private readonly IChallengeRatingRepository challengeRatingRepository;
        private readonly IMapper mapper;

        public ChallengeRatingController(IChallengeRatingRepository challengeRatingRepository, IMapper mapper)
        {
            this.challengeRatingRepository = challengeRatingRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<List<ChallengeRatingModel>> GetAll()
        {
            var results = await challengeRatingRepository.GetAllAsync();
            var models = mapper.Map<List<ChallengeRatingModel>>(results);
            return models;
        }
    }
}
