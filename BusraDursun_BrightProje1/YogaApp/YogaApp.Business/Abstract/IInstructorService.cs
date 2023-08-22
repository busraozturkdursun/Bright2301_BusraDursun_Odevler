using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Entity.Concrete;

namespace YogaApp.Business.Abstract
{
    public interface IInstructorService
    {
        #region Generic
        Task<Instructor> GetByIdAsync(int id);
        Task<List<Instructor>> GetAllAsync();
        Task CreateAsync(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        #endregion

        Task<List<Instructor>> GetInstructorCategoryAllAsync();

        Task<List<Instructor>> GetAllActiveCategoriesAsync(string categoryUrl = null);

    }
}
