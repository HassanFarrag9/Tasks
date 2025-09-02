using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [InverseProperty(nameof(Department.Manager))]
        public virtual Department? ManagerDepartment { get; set; }

        public int DeptId { get; set; }
        [InverseProperty(nameof(Department.Employes))]

        public virtual Department EmployeeDepartment { get; set; }
    }
}
