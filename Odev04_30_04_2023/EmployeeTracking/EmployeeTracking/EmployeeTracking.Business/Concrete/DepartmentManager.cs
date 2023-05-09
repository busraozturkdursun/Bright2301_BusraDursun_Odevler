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
    public class DepartmentManager : IDepartmentService
    {
   
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Create(Department department)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department department)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
           return _departmentRepository.GetAll();   
        }

        public Department GetById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
