using EmployeeTracking.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Data.Concrete.EfCore.Config
{
     public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.Name).IsRequired().HasMaxLength(300);
            builder.ToTable("Department");
            builder.HasData(

                new Department { Id = 1, Name = "Yazılım" },
                new Department { Id = 2, Name = "Muhasebe" },
                new Department { Id = 3, Name = "İnsan Kaynakları" },
                new Department { Id = 4, Name = "İhracat" });
        }
    }
}