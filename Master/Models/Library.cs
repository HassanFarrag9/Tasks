using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Library
    {
        [Key]
        public int LibraryId {  get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Location {  get; set; }
        #region BookLibrary_Contain
        public ICollection<Book> books=new List<Book>();
        #endregion
    }
}
