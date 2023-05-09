using EmployeeTracking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Business.Abstract
{
    public interface IDepartmentService
    {
        Department GetById(int id);
        List<Department> GetAll();
        void Create(Department department);
        void Update(Department department);
        void Delete(Department department);
    }
}
