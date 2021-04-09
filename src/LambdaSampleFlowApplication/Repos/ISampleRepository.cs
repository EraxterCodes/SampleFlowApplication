using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface ISampleRepository
    {
        Task<ICollection<Sample>> ReadAllSamplesAsync();
        Task<ICollection<Sample>> ReadAllSamplesAsync(string teamid);
        Task<ICollection<Sample>> ReadAsync(string sampleid);
    }
}