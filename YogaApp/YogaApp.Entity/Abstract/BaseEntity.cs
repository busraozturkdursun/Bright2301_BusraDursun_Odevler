using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaApp.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public virtual string Url  { get; set; }  //virtual : Miras alacak olan classlardan, değiştirilebilir olması için 
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;

    }
}
