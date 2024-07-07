using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCourse.Data;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListData()
        {
            return View(StudentData.Students);
        }
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Student NewStudent)
        {
            StudentData.Students.Add(NewStudent);
            return RedirectToAction("ListData");
        }
        public ActionResult Update(int id)
        {
            var student = StudentData.Students.Where(x => x.Id == id).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Update(Student updateStudent)
        {
            var student= StudentData.Students.Where(x => x.Id == updateStudent.Id).FirstOrDefault();
            student.Name = updateStudent.Name;
            student.LastName = updateStudent.LastName;
            student.Major= updateStudent.Major;
            student.Email = updateStudent.Email;
            student.TcNo= updateStudent.TcNo;

            return RedirectToAction("ListData");
        }
    }
}