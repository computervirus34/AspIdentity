using AspIdentity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentity.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Ahsan Habib",
                Age = "34",
                Position = "Software Developer"
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Test Name",
                Age = "34",
                Position = "Software Developer"
            });
        }
    }
}
