using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Assignment
    {
        [Key]
        public int AssignmentId {  get; set; }
        [MaxLength(200)]
        public string Title {  get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        #region StudentAssignment_Submit
        [ForeignKey(nameof(Student))]
        public int StudId {  get; set; }
        public Student Student { get; set; }

        #endregion
        #region CourseAssignment_have        
        public int CoursetId { get; set; }
        public Course Course { get; set; }
        #endregion
        #region SubmissionAssignment_Submit
        public ICollection<Submission> submissions=new List<Submission>();
        #endregion

    }
}
