using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Exam
    {
        [Key]
        public int ExamId {  get; set; }
        public DateTime ExamDate { get; set; }
        [MaxLength(50)]
        public string Type {  get; set; }
        #region StudentExam_take
        [ForeignKey(nameof(Student))]
        public int StudId {  get; set; }
        public Student Student { get; set; }
        #endregion
        #region CourseExam_have
        public int CourseId {  get; set; }
        public Course Course { get; set; }
        #endregion
        #region ExamResultExam_have
        public ICollection<ExamResult> examResults= new List<ExamResult>();
        #endregion

    }
}
