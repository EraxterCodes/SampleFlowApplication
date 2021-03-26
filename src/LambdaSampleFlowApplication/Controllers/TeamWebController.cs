using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Repos;

namespace WebApiNovo.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamWebController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;
        public TeamWebController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        
        [HttpGet]
        public async Task<ICollection<Team>> GetAll()
        {
            return await _teamRepository.ReadAllTeamsAsync();
        }

        // Test URL: api/teams/S-20200822-00025

        [HttpGet("{id}")]
        public async Task<Team> GetTeambyId(String id)
        {
            return await _teamRepository.ReadAsync(id);
        }
    }
}
