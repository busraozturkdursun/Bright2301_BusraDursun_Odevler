using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Entity.Abstract;

namespace YogaApp.Entity.Concrete
{
    public class Instructor:BaseEntity
    {
  

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public string PhotoUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }

    }
}
