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
    [Route("api/QCBatch")]
    public class QCBatchWebController : ControllerBase
    {
        private readonly IQCBatchRepository _QCBatchRepository;
        public QCBatchWebController(IQCBatchRepository QCBatchRepository)
        {
            _QCBatchRepository = QCBatchRepository;
        }
        
        [HttpGet]
        public async Task<ICollection<QCBatch>> GetAll() //Outputs a list of all QCBatch's as JSON
        {
            return await _QCBatchRepository.ReadAllQCBatchAsync();
        }

        [HttpGet("{id}")]
        public async Task<QCBatch> GetQCBatchbyId(String id) //Inputs : A QCBatchID. Outputs: The QCBatch as JSON
        {
            id = id.ToUpper();
            return await _QCBatchRepository.ReadAsync(id);
        }
    }
}
