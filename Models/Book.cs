using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf2.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublisheDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Author")]
        public int? AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}