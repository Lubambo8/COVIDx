using EFCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Models.ViewModel
{
    public class TestViewModel : ITest
    {
        public AlertModel Alert { get; set; }
        [Display(Name = "Barcode")]
        [Required(ErrorMessage = "Barcode is required")]
        public string BarCode { get; set; }

        [Display(Name = "Blood Pressure")]
        [Required(ErrorMessage = "Blood Pressure is required")]
        public string BloodPressure { get; set; }
        public int? LabUserID { get; set; }

        [Display(Name = "Oxygen Level")]
        [Required(ErrorMessage = "Oxygen Level is required")]
        public int OxygenLevel { get; set; }
        public DateTime? ResultDate { get; set; }

        public double Temperature
        {
            get
            {
                return Double.Parse(Temp);
            }
            set
            {
                Temperature = value;
            }
        }

        [RegularExpression(@"^[0-9]{0,2}\,?[0-9]{0,2}$", ErrorMessage = "Error! This is an Invalid Temperature. Input should contain numbers")]
        public string Temp { get; set; }
        public DateTime TestDate { get; set; }
        public int TestID { get; set; }
        public int TestRequestID { get; set; }
        public string TestResult { get; set; }
        public DateTime TestTime { get; set; }

        public string ModalID { get; set; }
    }
}
