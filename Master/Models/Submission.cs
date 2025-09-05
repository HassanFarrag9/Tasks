using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Submission
    {
        [Key]
        public int SubmissionId {  get; set; }

        public DateTime SubmissionDate {  get; set; }
        [Column(TypeName ="decimal(5,2)")]
        public decimal? Grade {  get; set; }
        #region SubmissionStudent_Submit
        public int StudId {  get; set; }
        public Student Student { get; set; }
        #endregion
        #region SubmissionAssignment_Submit
        public int AssignmentId {  get; set; }
        public Assignment Assignment { get; set; }

        #endregion

    }
}
