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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(YogaAppContext _context) : base(_context)
        {
        }
        private YogaAppContext Context
        {
            get { return _dbContext as YogaAppContext; }
        }

        public async Task<List<Category>> GetAllCategoryAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
               .Categorys
               .Where(c => c.IsDeleted == isDeleted)
               .AsQueryable();
            if (isActive != null)
            {
                result = result.Where(c => c.IsActive == isActive).AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
