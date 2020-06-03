using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Sidd",
                    Department = Dept.IT,
                    Email = "siddjasti@gmail.cm"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Suri",
                    Department = Dept.Payroll,
                    Email = "suri@gmail.cm"
                }
              );
        }
    }
}
