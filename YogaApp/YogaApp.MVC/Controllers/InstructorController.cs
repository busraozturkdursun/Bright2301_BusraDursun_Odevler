using Microsoft.AspNetCore.Mvc;
using YogaApp.Business.Abstract;
using YogaApp.Entity.Concrete;

namespace YogaApp.MVC.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _ınstructorManager;

        public InstructorController(IInstructorService ınstructorManager)
        {
            _ınstructorManager = ınstructorManager;
        }

   
    }
}
