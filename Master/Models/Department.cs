using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public DateOnly? DateOfCreation { get; set; }
        public int? ManagerID { get; set; }
        [InverseProperty(nameof(Employee.ManagerDepartment))]
        public virtual Employee Manager { get; set; }
        [InverseProperty(nameof(Employee.EmployeeDepartment))]

        public virtual ICollection<Employee> Employes { get; set; } = new HashSet<Employee>();
    }
}
