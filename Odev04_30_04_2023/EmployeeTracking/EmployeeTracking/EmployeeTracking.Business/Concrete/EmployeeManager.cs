using EmployeeTracking.Business.Abstract;
using EmployeeTracking.Data.Abstract;
using EmployeeTracking.Data.Concrete.EfCore.Repositories;
using EmployeeTracking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
          return _employeeRepository.GetAll();
        }

        public Employee GetById(int id)
        {
           return _employeeRepository.GetById(id);  
        }

        public List<Employee> GetEmployeesDepartment()
        {
            return _employeeRepository.GetEmployeesDepartment();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
