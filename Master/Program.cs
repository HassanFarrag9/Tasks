using Master.Data;
using Master.Data_Seeding;
using Master.Models;
using Microsoft.EntityFrameworkCore;

namespace Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
            #region DataSeeding
            //ITIDbContextDataSeeding.seed(dbContext);
            #endregion

            #region Load NavigationProperty 
            //var EmployeeWithDepartment = dbContext.employees.FirstOrDefault(x => x.Id==10);
            //if (EmployeeWithDepartment is not null)
            //{
            //    Console.WriteLine($"EmpName :{EmployeeWithDepartment.Name}");
            //    Console.WriteLine($"DeptId :{EmployeeWithDepartment.DeptId}");
            //    Console.WriteLine($"DeptName :{EmployeeWithDepartment.EmployeeDepartment?.DeptName}");
            //}
            #endregion

            #region Loading RelatedData

            #region Eager Loading
            #region Example 1
            //var EmployeeWithDepartment = dbContext.employees.Include(x => x.EmployeeDepartment).ThenInclude(x => x.Manager).FirstOrDefault(x => x.Id==10);
            //if (EmployeeWithDepartment is not null)
            //{
            //    Console.WriteLine($"EmpName :{EmployeeWithDepartment.Name}");
            //    Console.WriteLine($"DeptId :{EmployeeWithDepartment.DeptId}");
            //    Console.WriteLine($"DeptName :{EmployeeWithDepartment.EmployeeDepartment?.DeptName}");
            //    Console.WriteLine($"ManagerId :{EmployeeWithDepartment.EmployeeDepartment?.Manager?.Name}");
            //    Console.WriteLine($"ManagerName :{EmployeeWithDepartment.EmployeeDepartment?.Manager?.Id}");
            //}
            #endregion
            #region Example 2
            //var EmployeeWithDepartment = dbContext.employees.Include(x => x.ManagerDepartment).FirstOrDefault(x => x.Id==10);
            //if (EmployeeWithDepartment is not null)
            //{
            //    Console.WriteLine($"EmpName :{EmployeeWithDepartment.Name}");
            //    Console.WriteLine($"DeptId :{EmployeeWithDepartment.DeptId}");
            //    Console.WriteLine($"DeptName :{EmployeeWithDepartment.EmployeeDepartment?.DeptName}");
            //}
            #endregion
            #region Example 3
            //var EmployeeWithDepartment = dbContext.employees.Include(x => x.EmployeeDepartment)
            //    .Where(x=>x.EmployeeDepartment.DeptName=="sales")
            //    .Select(x => new
            //    {
            //        EmployeeName=x.Name,
            //        Department=x.EmployeeDepartment.DeptName
            //    });
            //if (EmployeeWithDepartment is not null)
            //{
            //    foreach(var item in EmployeeWithDepartment)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            #endregion
            #endregion

            #region Explicit Loading
            #region Example 1
            //var EmployeeWithDepartment = dbContext.employees.FirstOrDefault(x => x.Id==10);
            //dbContext.Entry(EmployeeWithDepartment).Reference(x=>x.EmployeeDepartment).Load();
            //if (EmployeeWithDepartment is not null)
            //{
            //    Console.WriteLine($"EmpName :{EmployeeWithDepartment.Name}");
            //    Console.WriteLine($"DeptId :{EmployeeWithDepartment.DeptId}");
            //    Console.WriteLine($"DeptName :{EmployeeWithDepartment.EmployeeDepartment?.DeptName}");
            //}
            #endregion
            #region Example 2
            //var EmployeeWithDepartment = dbContext.departments.FirstOrDefault(x => x.Id==1);
            //if (EmployeeWithDepartment is not null)
            //{
            //    dbContext.Entry(EmployeeWithDepartment).Collection(x => x.Employes).Load();
            //    Console.WriteLine($"EmpName :{EmployeeWithDepartment.DeptName}");
            //    foreach (var item in EmployeeWithDepartment.Employes)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            #endregion
            #endregion

            #region Lazy Loading
            //var EmployeeWithDepartment = dbContext.employees.FirstOrDefault(x => x.Id==10);
            //if (EmployeeWithDepartment is not null)
            //{
            //    Console.WriteLine($"EmpName :{EmployeeWithDepartment.Name}");
            //    Console.WriteLine($"DeptId :{EmployeeWithDepartment.DeptId}");
            //    Console.WriteLine($"DeptName :{EmployeeWithDepartment.EmployeeDepartment?.DeptName}");
            //}
            #endregion

            #endregion


        }

    }


}


