using EmployeeTracking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Data.Abstract
{
    public interface IEmployeeRepository: IGenericRepository<Employee>  
    {
        public List<Employee> GetEmployeesDepartment();
    }
}
