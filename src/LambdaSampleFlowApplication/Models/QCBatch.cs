using System;
using System.Collections.Generic;

public class QCBatch
{
    public string Id { get; set; }

    public Dictionary<string, Sample> sampleMap { get; set; } // maps sampleId to a sample

    public static ICollection<QCBatch> stubs()
    {
        return new List<QCBatch> {
            new QCBatch { Id = "QB-20200825-00188", sampleMap = new Dictionary<string, Sample>() {
                {"S-20200822-00025", 
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
                }},
                {"S-20200822-00028", 
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
                }}
            }}
        };
    }
    
    public static QCBatch getQCBatchById(string id, ICollection<QCBatch> QCBatchList)
    {
        foreach (var qc in QCBatchList)
        {
            if (qc.Id.Equals(id))
            {
                return qc; 
            }
        }

        return null;
    }
}