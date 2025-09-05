using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Models
{
    internal class Book
    {
        [Key]
        public int BookId {  get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Author {  get; set; }
        [MaxLength(20)]
        public string ISBN {  get; set; }
        #region BookLibrary_Contain
        public int LibraryId {  get; set; }
        public Library Library { get; set; }
        #endregion
        #region BookBookloans_have
        public ICollection<Bookloans> Bookloans=new List<Bookloans>();
        #endregion

    }
}
