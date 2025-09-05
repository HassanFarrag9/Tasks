using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }    
        [MaxLength(100)]
        public string? OfficeLocation {  get; set; }

        #region StudentDepartment_Belong
        public ICollection<Student> students = new List<Student>();
        #endregion
        #region InstructorDepartment_Belong
        public ICollection<Instructor> instructors = new List<Instructor>();
        #endregion
        #region CourseDepartment_Belong
        public ICollection<Course> courses = new List<Course>();
        #endregion
        #region InstructorDepartment_Manage
        public int? ManagerId {  get; set; }
        public Instructor Manager { get; set; }
        #endregion


    }
}
