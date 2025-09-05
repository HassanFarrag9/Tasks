using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Bookloans
    {
        [Key]
        public int LoanId {  get; set; }
        public DateTime LoanDate {  get; set; }
        public DateTime? ReturnDate { get; set; }
        #region BookBookloans_have
        public int BookId {  get; set; }
        public Book Book { get; set; }
        #endregion
        #region StudentbookLoans_Borrow
        public int StudId {  get; set; }
        public Student Student { get; set; }
        #endregion
    }
}
