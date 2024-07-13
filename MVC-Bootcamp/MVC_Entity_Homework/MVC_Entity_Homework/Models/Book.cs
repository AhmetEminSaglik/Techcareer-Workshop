using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Entity_Homework.Models
{
    public class Book
    {

        public int Id { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Description ")]
        public string Desc { get; set; }

        [DisplayName("Page ")]
        public int Page { get; set; }

        [DisplayName("Author Full Name")]
        public string AuthorName { get; set; }
    }

}