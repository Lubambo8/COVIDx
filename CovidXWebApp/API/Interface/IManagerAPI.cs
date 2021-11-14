using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.API.Interface
{
    public interface IManagerAPI
    {
        List<TestRequest> GetAllTestRequest();
    }
}
