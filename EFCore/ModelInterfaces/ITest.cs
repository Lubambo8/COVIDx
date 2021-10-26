using System;

namespace EFCore.Model
{
    public interface ITest
    {
        string BarCode { get; set; }
        string BloodPressure { get; set; }
        int? LabUserID { get; set; }
        string OxygenLevel { get; set; }
        DateTime? ResultDate { get; set; }
        string Temperature { get; set; }
        DateTime TestDate { get; set; }
        int TestID { get; set; }
        int TestRequestID { get; set; }
        string TestResult { get; set; }
        TimeSpan TestTime { get; set; }
    }
}