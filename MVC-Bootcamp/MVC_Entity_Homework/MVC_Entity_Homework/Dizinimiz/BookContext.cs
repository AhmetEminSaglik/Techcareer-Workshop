using MVC_Entity_Homework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Entity_Homework.Dizinimiz
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookDatabase") { }
        public DbSet<Book> Books { get; set; }

    }
}