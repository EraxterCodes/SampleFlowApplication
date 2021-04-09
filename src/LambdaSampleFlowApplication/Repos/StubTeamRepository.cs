using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubTeamRepository : ITeamRepository
    {        
        public async Task<ICollection<Team>> ReadAllTeamsAsync() //Returns all Teams async
        {
            return await Task.Run(() => Team.stubs()); 
        }
        public async Task<Team> ReadAsync(string TeamId) // Inputs: A team id. Outputs: A Team object based on team id. 
        {
            return await Task.Run(() => Team.getTeamById(TeamId, Team.stubs()));      
        }
    }
}