using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class bookController : Controller
    {
        public Book book = new Book();
        // GET: book
        public ActionResult Index()
        {
            Book book = createBook();

            return View(book);
        }

        private Book createBook()
        {
            Author author = createAuthor();
            Book book = new Book();
            book.author = author;
            book.Name = "Clean Code";
            book.Desc = "Made read learn how to write clean, effective code.";
            book.page = 464;

            return book;
        }
        private Author createAuthor()
        {

            Author author = new Author();

            author.Name = "Robert C. Martin";
            author.BirthYear = 1952;

            return author;
        }
    }
}