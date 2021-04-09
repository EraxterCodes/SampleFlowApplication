using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubSecurityDepRepository : ISecurityDepRepository
    {        
        public async Task<ICollection<SecurityDepartment>> ReadAllSecurityDepsAsync() //outputs : Returns all SecurityDepartment
        {
            return await Task.Run(() => SecurityDepartment.stubs()); 
        }
        public async Task<SecurityDepartment> ReadAsync(string securityDepId) // Inputs : a SourceDepartment ID Outputs: Return a specific Source Department
        {
                return await Task.Run(() => SecurityDepartment.getSecurityDepByName(securityDepId, SecurityDepartment.stubs()));       // Return a specific SecurityDep 
        }
    }
}