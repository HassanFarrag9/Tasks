using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    
    internal class Enrollment
    {
        
        public int EnrollmentNum {  get; set; }
        [Column(TypeName="decimal(5,2)")]
        public decimal? Grade {  get; set; }
        #region StudentEnrollments_enroll
        public int StudId {  get; set; }
        public Student Student { get; set; }

        #endregion
        #region CourseEnrollments_enroll
        public int CourseId {  get; set; }
        public Course Course { get; set; }

        #endregion

    }
}
