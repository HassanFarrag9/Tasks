using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Course_inst
    {
        [Key]
        public int Inst_Id {  get; set; }
        public int Course_ID {  get; set; }
        public string Evaluate {  get; set; }
    }
}
