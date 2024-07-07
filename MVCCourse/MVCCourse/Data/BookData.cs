using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCCourse.Models;

namespace MVCCourse.Data
{
    public class BookData
    {
        public static List<Book> Books = new List<Book>() {
        new Book {
        Id=1,
        Name="Clean Code",
        Desc="Helps you create refactoreable codes.",
        PageNumber=-464,
        AuthorName="Robert Cecil Martin"
        },

        new Book {
        Id=2,
        Name="Effective Java",
        //Desc="Show how to write more optimized codes in Java",
        Desc="--",
        PageNumber=353,
        AuthorName=" Eric Freeman, Elisabeth Robson, Bert Bates, Kathy Sierra "
        },


        new Book {
        Id=3,
        Name="Atomic Habits",
        Desc="Helps you create refactoreable codes.",
        PageNumber=475,
        AuthorName="James Clear"
        },

          new Book {
        
        }

        };
    }
}