using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YogaApp.Data.Concrete.EfCore.Configs;
using YogaApp.Entity.Concrete;

namespace YogaApp.Data.Concrete.EfCore.Contexts
{
    public class YogaAppContext : DbContext
    {
        public YogaAppContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
