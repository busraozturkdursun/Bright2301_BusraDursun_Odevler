using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Business.Abstract;
using YogaApp.Data.Abstract;
using YogaApp.Entity.Concrete;

namespace YogaApp.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorManager(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public async Task CreateAsync(Instructor instructor)
        {
          await _instructorRepository.CreateAsync(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorRepository.Delete(instructor);
        }

        public async Task<List<Instructor>> GetAllActiveCategoriesAsync(string categoryUrl = null)
        {
            var result = await _instructorRepository.GetAllActiveCategoriesAsync(categoryUrl);
            return result;
        }
    
        public async Task<List<Instructor>> GetAllAsync()
        {
           var result = await _instructorRepository.GetAllAsync();
            return result;
        }

        public async Task<Instructor> GetByIdAsync(int id)
        {
            var result = await _instructorRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<List<Instructor>> GetInstructorCategoryAllAsync()
        {
            var result = await _instructorRepository.GetInstructorCategoryAllAsync();
            return result;
        }

        public void Update(Instructor instructor)
        {
            _instructorRepository.Update(instructor);
        }
    }
}
