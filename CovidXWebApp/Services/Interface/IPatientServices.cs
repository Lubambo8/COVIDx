using EFCore.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace CovidXWebApp.Services.Interface
{
    public interface IPatientServices
    {
        bool AddPatient(Patient model);

        List<SubtextOption> GetMedicalAidList();

        SelectList GetSuburbList();
    }
}
