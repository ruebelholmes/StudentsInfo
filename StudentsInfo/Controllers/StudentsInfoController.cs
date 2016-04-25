using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsInfo.Models;

namespace StudentsInfo.Content
{
    public class StudentsInfoController : Controller
    {
        // GET: StudentsInfo
        public ActionResult Index()
        {
            var brian = new FellowStudents( "Brian", "Black", 5, 10);
            var kate = new FellowStudents("Kate", "Brown", 5, 6);
            var kevin = new FellowStudents("Kevin", "Black", 5, 10);
            var seth = new FellowStudents("Seth", "Black", 5, 11);
            var tee = new FellowStudents("Tee", "Black", 5, 10);
            var zach = new FellowStudents("Zach", "Blonde", 5, 10);

            var fellowstudents = new List<FellowStudents>() { brian, kate, kevin, seth, tee, zach };
            return View(fellowstudents);
        }
    }
}