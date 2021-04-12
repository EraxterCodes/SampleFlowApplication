using System;

public class ModificationDate
{
    //Ask Nina whats the difference between RECEIVEDDT and RECEIVEDDT_1 and fix this accordingly
    //What is U_SPCORDERINGDT ??? Is it needed
    public int AUDITSEQUENCE { get; set; } 
    public Enum status { get; set; } 
    public DateTime  MODDT { get; set; } 
    public DateTime  COLLECTIONDT { get; set; } 
    public DateTime? RECEIVEDDT { get; set; } 
    public DateTime  CREATEDT { get; set; } 
    public DateTime  COMPLETEDT { get; set; } 
    public DateTime? SUBMITTEDDT { get; set; } 
    public DateTime? REVIEWEDDT { get; set; } //MODDT where SAMPLESTATE is Reviewed
}