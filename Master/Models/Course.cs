using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Course
    {
        [Key]
        public int CourseId {  get; set; }
        [MaxLength(200)]
        public string Title {  get; set; }
        public int Credits {  get; set; }
        #region CourseDepartment_Belong
        public int DeptId {  get; set; }
        public Department Department { get; set; }

        #endregion
        #region CourseAssignment_have
        public ICollection<Assignment> assignments=new List<Assignment>();
        #endregion
        #region CourseExam_have
        public ICollection<Exam> exams = new List<Exam>();
        #endregion
        #region CourseEnrollments_enroll
        public ICollection<Enrollment> enrollments = new List<Enrollment>();
        #endregion
        #region CourseScheduleCourse_Teach
        public ICollection<CourseSchedule> courseSchedules=new List<CourseSchedule>();
        #endregion
    }
}
