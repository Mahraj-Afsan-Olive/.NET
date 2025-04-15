using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            var s1 = new Student()
            {
                Name = "Olive",
                Degree = "CSE",
                Institute = "AIUB",
                Year = "2025",
                Result = 3.94
            };
            var s2 = new Student()
            {
                Name = "Tawsif",
                Degree = "CSE",
                Institute = "AIUB",
                Year = "2025",
                Result = 3.75
            };
            Student[] students = new Student[] { s1, s2 };
            return View(students);
        }

        public ActionResult Projects()
        {
            List<Course> courses = new List<Course>();

            Course c1 = new Course
            {
                Name = "Adv .Net",
                RoomNo = "92023",
                Credit = 3
            };

            Course c2 = new Course
            {
                Name = "Adv Webtech",
                RoomNo = "91022",
                Credit = 3
            };

            courses.Add(c1);
            courses.Add(c2);

            return View(courses);
        }


        public ActionResult Reference()
        {
            return View();
        }




    }
}