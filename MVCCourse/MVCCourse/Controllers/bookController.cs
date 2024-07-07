using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class BookController : Controller
    {
        public Book book = new Book();
        // GET: book
        public ActionResult Index()
        {
            Book book = createBook();
            Student student = createStudent();

            Console.WriteLine(student);
            Console.WriteLine(book);

            return View(Tuple.Create<MVCCourse.Models.Book, MVCCourse.Models.Student>(book, student));
        }

        private Student createStudent()
        {
            Student student = new Student();

            student.Name = "Ahmet Emin";
            student.LastName = "SAĞLIK";
            student.TcNo = "12312312300";
            student.Major = "Software Engineer";
            student.RegisteredYear = 2018;
            student.email = "ahmeteminsaglik@gmail.com";

            return student;
        }

        private Book createBook()
        {
            Author author = createAuthor();
            Book book = new Book();
            book.author = author;
            book.Name = "Clean Code";
            book.Desc = "Made read learn how to write clean, effective code.";
            book.pageNumber = 464;

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