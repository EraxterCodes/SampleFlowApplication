using System;
using System.Collections.Generic;
public class SourceDepartment
{
    public string Classification {get; set;} // Sample type in all caps INDATA

    public string LimsID {get; set;} // Formerly U_SourceDept

    public string SourceDepartmentId {get; set;} // Formerly organisationaldepartmentsource

    public static SourceDepartment getSourceDepartmentById(string dept_id, ICollection<SourceDepartment> SourceDepList)
    {
        foreach (var sdep in SourceDepList)
        {
            if (sdep.SourceDepartmentId.Equals(dept_id)) return sdep; 
            
        }
        return null; 
    }
    
    public static ICollection<SourceDepartment> stubs()
    {
        return new List<SourceDepartment> {
            new SourceDepartment { Classification = "Stability", LimsID = "c17",SourceDepartmentId = "433" },
        };
    }
}