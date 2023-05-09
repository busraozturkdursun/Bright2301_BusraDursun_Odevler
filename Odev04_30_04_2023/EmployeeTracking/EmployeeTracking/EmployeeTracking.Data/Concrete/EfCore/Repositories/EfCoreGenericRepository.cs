using EmployeeTracking.Data.Abstract;
using EmployeeTracking.Data.Concrete.EfCore.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeTracking.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        EmployeeTrackingContext _trackingContext = new EmployeeTrackingContext();



        public void Create(TEntity entity)
        {
           _trackingContext.Set<TEntity>().Add(entity);
           _trackingContext.SaveChanges();  
        }

        public void Delete(TEntity entity)
        {
            _trackingContext.Set<TEntity>().Remove(entity);
            _trackingContext.SaveChanges(); 
        }

        public List<TEntity> GetAll()
        {
            return _trackingContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _trackingContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _trackingContext.Set<TEntity>().Update(entity);
            _trackingContext.SaveChanges();
        }

    }
}
