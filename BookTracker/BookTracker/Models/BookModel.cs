using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BookTracker.Models
{
    public class Book
    {
        //id
        public int ID { get; set; }
        //name
        public string Name { get; set; }
        //date read
        public DateTime DateRead { get; set; }
        //review
        public string Review { get; set; }
        //author
        public string Author { get; set; }
        //book description
        public string Description { get; set; }
        //quotes
        public string Quotes { get; set; }
        //rating
        public int Rating { get; set; }

    }

}
