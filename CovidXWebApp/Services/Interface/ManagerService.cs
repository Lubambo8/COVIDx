using EFCore;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.Services.Interface
{
    public class ManagerService : IManagerService
    {
        private readonly DatabaseContext _context;

        public ManagerService(DatabaseContext context)
        {
            _context = context;
        }

        public List<TestRequest> GetAllTestRequest()
        {
            return _context.TestRequest.GetDetails().ToList();
        }
    }
}
