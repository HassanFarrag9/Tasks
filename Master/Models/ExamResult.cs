using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class ExamResult
    {
        [Key]
        public int ExamResultId { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Score { get; set; }
        #region ExamResultExam_have
        public int ExamId {  get; set; }
        public Exam Exam { get; set; }
        #endregion
        #region ExamResultStudent_Get
        public int StudId {  get; set; }
        public Student Student { get; set; }
        #endregion

    }
}
