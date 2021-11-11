using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Services.Interface
{
    public interface IManagerService
    {
        List<TestRequest> GetAllTestRequest();
    }
}
