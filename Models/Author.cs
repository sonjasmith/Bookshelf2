﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookshelf2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}