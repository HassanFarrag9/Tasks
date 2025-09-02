using Master.Data;
using Master.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Master.Data_Seeding
{
    internal class ITIDbContextDataSeeding
    {
        public static void seed(ITIDbContext dbContext)
        {
            #region Departments
            if (!dbContext.departments.Any())
            {
                var DepartmentData = File.ReadAllText("files\\departments.json");
                var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentData);
                if (Departments?.Count()>0)
                {
                    dbContext.departments.AddRange(Departments);
                    dbContext.SaveChanges();
                }
            }
            #endregion
            #region Employees
            if (!dbContext.employees.Any())
            {
                var EmployeeData = File.ReadAllText("files\\employees.json");
                var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeeData);
                if (Employees?.Count()>0)
                {
                    dbContext.employees.AddRange(Employees);
                    dbContext.SaveChanges();
                }
            }
            #endregion
        }

    }
}
