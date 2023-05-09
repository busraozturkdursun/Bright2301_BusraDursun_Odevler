using EmployeeTracking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Business.Abstract
{
    public interface IEmployeeService
    {
        Employee GetById(int id);
        List<Employee> GetAll();
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        public List<Employee> GetEmployeesDepartment();

    }
}
