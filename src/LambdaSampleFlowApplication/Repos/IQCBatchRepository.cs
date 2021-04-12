using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface IQCBatchRepository
    {
        Task<ICollection<QCBatch>> ReadAllQCBatchAsync();
        Task<QCBatch> ReadAsync(string QCBatchId);
    }
}