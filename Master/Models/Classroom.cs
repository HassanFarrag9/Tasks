using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Classroom
    {
        [Key]
        public int ClassroomId {  get; set; }
        [MaxLength(100)]
        public string Building { get; set; }
        [MaxLength(50)]
        public string RoomNumber { get; set; }
        public int Capacity {  get; set; }
        #region CourseScheduleClassRoom_Link
        public ICollection<CourseSchedule> courseSchedules= new List<CourseSchedule>();
        #endregion
    }
}
