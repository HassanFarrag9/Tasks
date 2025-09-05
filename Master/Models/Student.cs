using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(200)]
        public string FullName { get; set; }
        [EmailAddress]
        [MaxLength(150)]
       
        public string Email {  get; set; }
        [Phone]
        [MaxLength(20)]
        public string? Phone { get; set; }
        
        public DateOnly BirthDate { get; set; }
        [MaxLength(300)]
        public string? Address {  get; set; }
        #region StudentDepartment_Belong
        [ForeignKey(nameof(department))]
        public int DeptId { get; set; }
        public Department department { get; set; }

        #endregion
        #region StudentAssignment_Submit
        public ICollection<Assignment> assignments=new List<Assignment>();
        #endregion
        #region StudentExam_take
        public ICollection<Exam> exams=new List<Exam>();
        #endregion
        #region StudentEnrollments_enroll
        public ICollection<Enrollment>enrollments=new List<Enrollment>();

        #endregion
        #region ExamResultStudent_Get
        public ExamResult examResult { get; set; }

        #endregion
        #region SubmissionStudent_Submit
        public ICollection<Submission> submissions=new List<Submission>();
        #endregion
        #region StudentbookLoans_Borrow
        public ICollection<Bookloans> Bookloans=new List<Bookloans>();
        #endregion

    }
}
