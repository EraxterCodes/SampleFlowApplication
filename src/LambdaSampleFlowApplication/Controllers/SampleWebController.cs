using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repos;

namespace WebApiNovo.Controllers
{
    [ApiController]
    [Route("api/samples")]
    public class SampleWebController : ControllerBase
    {
        private readonly ISampleRepository _sampleRepository;
        public SampleWebController(ISampleRepository sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }
        
        [HttpGet]
        public async Task<ICollection<Sample>> GetAll() //Outputs a list of all Samples as JSON
        {
            return await _sampleRepository.ReadAllSamplesAsync();
        }

        // Test URL: api/samples/S-20200822-00025

        [HttpGet("{id}")]
        public async Task<ICollection<Sample>> GetSamplebyId(String id) //Inputs : A Sample ID. Outputs:The Sample as JSON
        {
            return await _sampleRepository.ReadAsync(id);

        // Test URL: api/samples/team/1
        }
        [HttpGet("team/{id}")]
        public async Task<ICollection<Sample>> GetSamplesbyTeamId(String id)//Inputs : A Team ID. Outputs:ALl samples belonging to that team.
        {
            return await _sampleRepository.ReadAllSamplesAsync(id);
        }
    }
}
