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
    [Route("api/SourceDeps")]
    public class SourceDepWebController : ControllerBase
    {
        private readonly ISourceDepRepository _SourceDepRepository;
        public SourceDepWebController(ISourceDepRepository SourceDepRepository)
        {
            _SourceDepRepository = SourceDepRepository;
        }
        
        [HttpGet]
        public async Task<ICollection<SourceDepartment>> GetAll() //Outputs a list of all SourceDepartment as JSON
        {
            return await _SourceDepRepository.ReadAllSourceDepsAsync();
        }

        [HttpGet("{id}")]
        public async Task<SourceDepartment> GetSourceDepbyId(String id) //Inputs : A SourceDepartment ID. Outputs:The SourceDepartment as JSON
        {
            return await _SourceDepRepository.ReadAsync(id);
        }
    }
}
