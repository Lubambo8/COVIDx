using EFCore;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.API.Interface
{
    public class ManagerAPI : IManagerAPI
    {
        private readonly DatabaseContext _context;

        public ManagerAPI(DatabaseContext context)
        {
            _context = context;
        }

        public List<TestRequest> GetAllTestRequest()
        {
            return _context.TestRequest.GetDetails().ToList();
        }
    }
}
