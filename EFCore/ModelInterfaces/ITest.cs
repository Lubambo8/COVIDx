using System;

namespace EFCore.Model
{
    public interface ITest
    {
        string BarCode { get; set; }
        string BloodPressure { get; set; }
        int? LabUserID { get; set; }
        int OxygenLevel { get; set; }
        DateTime? ResultDate { get; set; }
        double Temperature { get; set; }
        DateTime TestDate { get; set; }
        int TestID { get; set; }
        int TestRequestID { get; set; }
        string TestResult { get; set; }
        DateTime TestTime { get; set; }
    }
}