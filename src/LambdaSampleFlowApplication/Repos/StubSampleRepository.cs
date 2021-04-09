using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubSampleRepository : ISampleRepository
    {        
        public async Task<ICollection<Sample>> ReadAllSamplesAsync()  //Returns all samples
        {
            return await Task.Run(() => Sample.stubs());
        }
       
        public async Task<ICollection<Sample>> ReadAllSamplesAsync(string teamid)// Inputs : a team ID. Outputs: all samples for a specific team
        {
            return await Task.Run(() => Sample.getSampleByTeamId(teamid, Sample.stubs())); 
        }
        
        public async Task<ICollection<Sample>> ReadAsync(string sampleId)   // Inputs : a Sample ID Outputs: Return a specific Sample object
        {
                return await Task.Run(() => Sample.getSampleById(sampleId, Sample.stubs()));      
        }
    }
}