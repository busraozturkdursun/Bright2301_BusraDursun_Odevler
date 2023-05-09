using EmployeeTracking.Data.Abstract;
using EmployeeTracking.Data.Concrete.EfCore.Contexts;
using EmployeeTracking.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Data.Concrete.EfCore.Repositories
{
    public class EfCoreEmployeeRepository : EfCoreGenericRepository<Employee>, IEmployeeRepository
    {

        EmployeeTrackingContext _context = new EmployeeTrackingContext();
        public List<Employee> GetEmployeesDepartment() {

            var result = _context
                .Employees
                .Include(e => e.Department)
                .ToList();
            return result;
          
        }
    }
}
