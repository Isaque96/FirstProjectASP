using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Project.Data;
using Microsoft.EntityFrameworkCore;

namespace Project.Services
{
    public class DepartmentService
    {
        private readonly ProjectContext _context;

        public DepartmentService(ProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
