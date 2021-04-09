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
    [Route("api/SecurityDeps")]
    public class SecurityDepWebController : ControllerBase
    {
        private readonly ISecurityDepRepository _SecurityDepRepository;
        public SecurityDepWebController(ISecurityDepRepository SecurityDepRepository)
        {
            _SecurityDepRepository = SecurityDepRepository;
        }
        
        [HttpGet]
        public async Task<ICollection<SecurityDepartment>> GetAll() //Outputs a list of all SecurityDepartments as JSON
        {
            return await _SecurityDepRepository.ReadAllSecurityDepsAsync();
        }        

        [HttpGet("{id}")]
        public async Task<SecurityDepartment> GetSecurityDepbyId(String id) //Inputs : A SecurityDepartment ID. Outputs:The SecurityDepartment as JSON
        {
            return await _SecurityDepRepository.ReadAsync(id);
        }
    }
}
