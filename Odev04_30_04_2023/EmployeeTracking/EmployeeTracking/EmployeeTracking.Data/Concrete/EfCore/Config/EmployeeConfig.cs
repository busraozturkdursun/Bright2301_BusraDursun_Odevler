using EmployeeTracking.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking.Data.Concrete.EfCore.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            
                builder.HasKey(e => e.Id);
                builder.Property(e => e.Id).ValueGeneratedOnAdd();
                builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                builder.Property(e => e.Salary).IsRequired().HasMaxLength(300);
                builder.Property(e => e.DepartmentId).IsRequired();
                builder.ToTable("Employee");



                builder.HasData(
                    new Employee
                    {
                        Id = 1,
                        FirstName = "Büşra",
                        LastName = "Dursun",
                        Salary = 30000,
                        DepartmentId = 1

                    },
                    new Employee
                    {
                        Id = 2,
                        FirstName = "Erdinç",
                        LastName = "Dursun",
                        Salary = 20000,
                        DepartmentId = 4

                    },
                    new Employee
                    {
                        Id = 3,
                        FirstName = "Ömer",
                        LastName = "Dursun",
                        Salary = 5000,
                        DepartmentId = 2

                    },
                      new Employee
                      {
                          Id = 4,
                          FirstName = "Zeynep",
                          LastName = "Doğan",
                          Salary = 15000,
                          DepartmentId = 3

                      },
                      new Employee
                      {
                          Id = 5,
                          FirstName = "Ayşe",
                          LastName = "Doğan",
                          Salary = 28000,
                          DepartmentId = 1

                      });

            }
        }
    }

