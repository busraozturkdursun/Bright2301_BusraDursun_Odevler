namespace YogaApp.MVC.Areas.Admin.Models
{
    public class CategoryUpdateViewModel
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public string Url { get; set; }

        public bool IsActive { get; set; }
    }
}
