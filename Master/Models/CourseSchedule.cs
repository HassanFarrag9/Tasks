using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class CourseSchedule
    {
        [Key]
        public int ScheduleId {  get; set; }
        [MaxLength(20)]
        public string DayOfWeek {  get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        #region CourseScheduleInstructor_Teach
        public int InsId {  get; set; }
        public Instructor Instructor { get; set; }

        #endregion
        #region CourseScheduleCourse_Teach
        public int CourseId {  get; set; }  
        public Course Course { get; set; }
        #endregion
        #region CourseScheduleClassRoom_Link
        public int ClassRoomId {  get; set; }
        public Classroom Classroom { get; set; }
        #endregion


    }
}
