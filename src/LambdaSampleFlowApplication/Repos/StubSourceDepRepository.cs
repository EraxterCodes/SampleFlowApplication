using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Repos
{
    public class StubSourceDepRepository : ISourceDepRepository
    {
        public async Task<ICollection<SourceDepartment>> ReadAllSourceDepsAsync() //Outputs: Returns all SourceDepartment async
        {
            return await Task.Run(() => SourceDepartment.stubs()); 
        }
        public async Task<SourceDepartment> ReadAsync(string sourceDepId) // Inputs : a SourceDepartment ID Outputs: Return a specific Source Dep   
        {
            return await Task.Run(() => SourceDepartment.getSourceDepartmentById(sourceDepId,SourceDepartment.stubs()));   
        }
    }
}