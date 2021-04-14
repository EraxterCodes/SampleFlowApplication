using System;
using System.Collections.Generic;

public class Team 
{
    public string TeamId { get; set; } 
    public List<string> Methods { get; set; } 

    public static Team stub()
    {
        return new Team { TeamId = "3533_01", Methods = new List<string> { "B307-10", "222325_Sema-GIP" }};
    }

    public static ICollection<Team> stubs()
    {
        return new List<Team> {
            new Team { TeamId = "3533_01", Methods = new List<string> { "B307-10", "222325_Sema-GIP" } },
            new Team { TeamId = "3533_02", Methods = new List<string> { "B212-11_Sema-GIP", "B307-10","B410-10_Phenol" } }
        };
    }

        public static Team getTeamById(string id, ICollection<Team> teamList)
    {
        foreach (var t in teamList)
        {
            if (t.TeamId.Equals(id))
            {
                return t; 
            }
        }
        return null;
    }
}