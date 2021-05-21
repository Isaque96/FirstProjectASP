using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Project.Data;

namespace Project.Services
{
    public class DepartmentService
    {
        private readonly ProjectContext _context;

        public DepartmentService(ProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
