using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Stud_Course
    {
        public int stud_ID { get; set; }
        public Student Student { get; set; }
        public int Course_ID { get; set; }
        public Course Course { get; set; }
        public double Grade { get; set; }
    }
}
