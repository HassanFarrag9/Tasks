using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Instructor
    {
        [Key]
        public int InstructorId {  get; set; }
        [MaxLength(200)]
        public string FullName { get; set; }
        [MaxLength(150)]
        public string Email {  get; set; }
        [MaxLength(20)]
        public string? phone {  get; set; }  
        public DateOnly HireDate {  get; set; }
        #region InstructorDepartment_Belong
        [ForeignKey(nameof(Department))]
        public int  DeptId { get; set; }
        public Department Department { get; set; }

        #endregion
        #region InstructorDepartment_Manage
        public Department? ManageDepartment {  get; set; }
        #endregion
        #region CourseScheduleInstructor_Teach
        
        public ICollection<CourseSchedule> courseSchedules=new List<CourseSchedule>();
        #endregion

    }
}
