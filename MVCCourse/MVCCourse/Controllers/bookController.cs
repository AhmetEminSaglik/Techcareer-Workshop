using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCourse.Data;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            return View(BookData.Books);
        }
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Book NewBook)
        {
            BookData.Books.Add(NewBook);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var book = BookData.Books.Where(x => x.Id == id).FirstOrDefault();
            return View(book);
        }

        [HttpPost]
        public ActionResult Update(Book updateBook)
        {
            var book = BookData.Books.Where(x => x.Id == updateBook.Id).FirstOrDefault();
            book.Name = updateBook.Name;
            book.AuthorName = updateBook.AuthorName;
            book.PageNumber = updateBook.PageNumber;

            return RedirectToAction("Index");

        }
    }
}