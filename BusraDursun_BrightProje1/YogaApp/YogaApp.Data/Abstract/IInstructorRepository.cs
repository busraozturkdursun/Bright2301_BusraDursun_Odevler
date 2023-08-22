using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Entity.Concrete;

namespace YogaApp.Data.Abstract
{
    public interface IInstructorRepository : IGenericRepository<Instructor>
    {
        Task<List<Instructor>> GetInstructorCategoryAllAsync();
        Task<List<Instructor>> GetAllActiveCategoriesAsync(string categoryUrl = null);

    }
}
