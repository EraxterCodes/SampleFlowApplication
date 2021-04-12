using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubQCBatchDepRepository : IQCBatchRepository
    {        
        public async Task<ICollection<QCBatch>> ReadAllQCBatchAsync() //outputs : Returns all SecurityDepartment
        {
            return await Task.Run(() => QCBatch.stubs()); 
        }
        public async Task<QCBatch> ReadAsync(string QCBatchId) // Inputs : a SourceDepartment ID Outputs: Return a specific Source Department
        {
            return await Task.Run(() => QCBatch.getQCBatchById(QCBatchId, QCBatch.stubs())); // Return a specific SecurityDep 
        }
    }
}