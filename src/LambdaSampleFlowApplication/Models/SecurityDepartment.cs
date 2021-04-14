using System;
using System.Collections.Generic;
public class SecurityDepartment 
{
    public string name { get; set; }

    public string LimsID { get; set; }

    public ICollection<Team> teams { get; set; }

    Team getTeam(string team_id)
    {
        throw new NotImplementedException();
    }

    public static SecurityDepartment stub()
    {
        return new SecurityDepartment { name = "3533",LimsID = "c25", teams = Team.stubs()};
    }

    public static ICollection<SecurityDepartment> stubs()
    {
        return new List<SecurityDepartment> {
            new SecurityDepartment { name = "3533",LimsID = "c25", teams = Team.stubs()}
        };
    }

    public static SecurityDepartment getSecurityDepById(string name, ICollection<SecurityDepartment> securityDepList)
    {
        foreach (var s in securityDepList)
        {
            if (s.name.Equals(name))
            {
                return s; 
            }
        }
        return null;
    }
}
