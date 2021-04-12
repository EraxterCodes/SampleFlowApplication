using System;
using System.Collections.Generic;

public class Sample
{
    //Originally prefixed with 'S_'
    public string SampleId { get; set; }

    public string ParamListId { get; set; } // Method

    public ModificationDate ModificationDate { get; set; } //Have all the dates for the samples

    //Originally prefixed with 'S_'
    public string QCBatchId { get; set; }

    //Originally prefixed with 'U_'
    public string SamepleUnit { get; set; } //This can maybe be made into Enums? Limited amount of units

    //Originally prefixed with 'U_'
    public string SampleInfo { get; set; }

    //Originally prefixed with 'U_'
    public string ProductName { get; set; }

    public Team Team { get; set; }

    public static ICollection<Sample> getSampleByTeamId(string id, ICollection<Sample> sampleList)
    {
        List<Sample> returnList = new List<Sample>(); 
        foreach (var s in sampleList)
        {
            if (s.Team.TeamId.Equals(id))
            {
                returnList.Add(s); 
            }
        }
        return returnList; 
    }

    public static ICollection<Sample> getSampleById(string id, ICollection<Sample> sampleList)
    {
        var returnlist = new List<Sample>();
        foreach (var s in sampleList)
        {
            if (s.SampleId.Equals(id))
            {
                returnlist.Add(s);
            }
        }
        if (returnlist.Count == 0) return null;
        else return returnlist;
    }

    public static Sample stub()
    {
        return new Sample
        {
            SampleId = "S-20200822-00025",
            ParamListId = "B307-10",
            ModificationDate = new ModificationDate
            {
                AUDITSEQUENCE = 19,
                status = Enum.Reviewed,
                MODDT = new DateTime(2021,1,20,13,20,0), //Samme som ReviewedDT for samples hvor Enum er reviewed
                COLLECTIONDT = new DateTime(2020,8,24,8,55,0),
                RECEIVEDDT = new DateTime(2020,8,24,11,20,0),
                CREATEDT = new DateTime(2020,8,22),
                COMPLETEDT = new DateTime(2021,1,20,13,20,0),
                SUBMITTEDDT = new DateTime(2020,8,24,10,12,0),
                REVIEWEDDT = new DateTime(2021,1,20,13,20,0), // Samme som MODDT når sample er reviewed

            },
            Team = Team.stub(),
            QCBatchId = "QB-20200825-00188",
            ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
        };
    }

    public static ICollection<Sample> stubs()
    {

        return new List<Sample>
        {
            new Sample
            {
                SampleId = "S-20200822-00025",
                ParamListId = "B307-10",
                ModificationDate = new ModificationDate
                {
                AUDITSEQUENCE = 19,
                status = Enum.Reviewed,
                MODDT = new DateTime(2021,1,20,13,20,0), //Samme som ReviewedDT for samples hvor Enum er reviewed
                COLLECTIONDT = new DateTime(2020,8,24,8,55,0),
                RECEIVEDDT = new DateTime(2020,8,24,11,20,0),
                CREATEDT = new DateTime(2020,8,22),
                COMPLETEDT = new DateTime(2021,1,20,13,20,0),
                SUBMITTEDDT = new DateTime(2020,8,24,10,12,0),
                REVIEWEDDT = new DateTime(2021,1,20,13,20,0), // Samme som MODDT når sample er reviewed

            },
                Team = Team.stub(),
                QCBatchId = "QB-20200825-00188",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            },

            new Sample
            {
                SampleId = "S-20200822-00025",
                ParamListId = "222325_Sema-GIP",
                ModificationDate = new ModificationDate
                {
                    AUDITSEQUENCE = 7,
                    status = Enum.Received,
                    MODDT = new DateTime(2020,8,24,11,12,0),
                    COLLECTIONDT = new DateTime(2020,8,24,8,55,0),
                    RECEIVEDDT = new DateTime(2020,8,24,11,22,0),
                    CREATEDT = new DateTime(2020,8,22),
                    COMPLETEDT = new DateTime(2021,1,20,13,20,0),
                    SUBMITTEDDT = new DateTime(2020,8,24,10,12,0),
                    REVIEWEDDT = null
                },
                Team = Team.stub(),
                QCBatchId = "QB-20200827-00078",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            },

            new Sample
            {
                SampleId = "S-20200822-00028",
                ParamListId = "B212-11_Sema-GIP",
                ModificationDate = new ModificationDate
                {
                    AUDITSEQUENCE = 8,
                    status = Enum.Received,
                    MODDT = new DateTime(2020,8,27,12,32,0),
                    COLLECTIONDT = new DateTime(2020,8,24,8,55,0),
                    RECEIVEDDT = new DateTime(2020,8,24,11,22,0),
                    CREATEDT = new DateTime(2020,8,22),
                    COMPLETEDT = new DateTime(2021,1,20,13,20,0),
                    SUBMITTEDDT = new DateTime(2020,8,24,10,12,0),
                    REVIEWEDDT = null
                },
                Team = Team.stub(),
                QCBatchId = "QB-20200909-00409",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            },

            new Sample
            {
                SampleId = "S-20200822-00028",
                ParamListId = "B307-10",
                ModificationDate = new ModificationDate
                {
                    AUDITSEQUENCE = 4,
                    status = Enum.Initial,
                    MODDT = new DateTime(2020,8,24,8,55,23),
                    COLLECTIONDT = new DateTime(2020,8,24,8,55,23),
                    RECEIVEDDT = null,
                    CREATEDT = new DateTime(2020,8,22,0,2,47),
                    COMPLETEDT = new DateTime(2021,1,20,13,20,0),
                    SUBMITTEDDT = null,
                    REVIEWEDDT = null
                },
                Team = Team.stub(),
                QCBatchId = "QB-20200825-00188",
                ProductName = "OW GIP ratio 2:2 mg/ml Sema:GIP in 3 ml Cartridge"
            }
        };
    }
}