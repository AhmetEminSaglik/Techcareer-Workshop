using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCCourse.Models;

namespace MVCCourse.Data
{
    public class StudentData
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Ahmet Emin",
                LastName = "SAĞLIK",
                TcNo = "12312312311",
                Major = "Software Engineer",
                RegisteredYear = 2024,
                Email = "ahmeteminsaglik@gmail.com"
            },
            new Student
            {
                Id = 2,
                Name = "Abdulah Ahmet",
                LastName = "AŞKIN",
                TcNo = "23423423422",
                Major = "Game Developer",
                RegisteredYear = 2020,
                Email = "abdulah@gmail.com"
            },
            new Student
            {
                Id = 3,
                Name = "Omer",
                LastName = "Koramaz",
                TcNo = "34534534533",
                Major = "Web Developer",
                RegisteredYear = 2017,
                Email = "omer@gmail.com"
            }
        };
    }
}