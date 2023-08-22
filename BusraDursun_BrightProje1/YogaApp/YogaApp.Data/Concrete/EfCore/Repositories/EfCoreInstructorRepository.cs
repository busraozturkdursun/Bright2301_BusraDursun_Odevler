using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Data.Abstract;
using YogaApp.Data.Concrete.EfCore.Contexts;
using YogaApp.Entity.Concrete;

namespace YogaApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreInstructorRepository : EfCoreGenericRepository<Instructor>, IInstructorRepository
    {
        public EfCoreInstructorRepository(YogaAppContext _context) : base(_context)
        {

        }
        private YogaAppContext Context
        {
            get { return _dbContext as YogaAppContext; }
        }

        public async Task<List<Instructor>> GetAllActiveCategoriesAsync(string categoryUrl = null)
        {
            var result = Context
                  .Instructors
                  .Where(a => a.IsActive && !a.IsDeleted)
                  .Include(b => b.Category)
                  .AsQueryable();
            if (categoryUrl != null)
            {
                result = result
                      .Where(b => b.Category.Url == categoryUrl)
                      .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<List<Instructor>> GetInstructorCategoryAllAsync()
        {
            var result = await Context
                .Instructors
                .Where(i=>i.IsActive)
                .Include(i=>i.Category)
                .ToListAsync();
            return result;
        }
    }
}
