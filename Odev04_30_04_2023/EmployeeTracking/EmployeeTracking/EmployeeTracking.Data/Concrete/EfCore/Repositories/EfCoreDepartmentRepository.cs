using EmployeeTracking.Data.Abstract;
using EmployeeTracking.Data.Concrete.EfCore.Contexts;
using EmployeeTracking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Data.Concrete.EfCore.Repositories
{
    public class EfCoreDepartmentRepository : EfCoreGenericRepository<Department>, IDepartmentRepository
    {
        
    }
}
