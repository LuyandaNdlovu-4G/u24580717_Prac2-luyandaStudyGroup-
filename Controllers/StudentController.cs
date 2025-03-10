using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace u24580717_Prac2_luyandaStudyGroup_.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentView()
        {
            List<Models.Student> people = new List<Models.Student>();
            people.Add(new Models.Student { StudentNumber = "u24580717", FirstName = "Luyanda", LastName = "Ndlovu", EmailAddress = "u24580717@tuks.co.za", myLink = "~/HTML/PersonalPage.html" });
            people.Add(new Models.Student { StudentNumber = "u14904721", FirstName = "Ayanda", LastName = "Mkize", EmailAddress = "u14904721@tuks.co.za", myLink = "~/HTML/Person01.html" });
            people.Add(new Models.Student { StudentNumber = "u01237589", FirstName = "Tristin", LastName = "Torres", EmailAddress = "u01237589@tuks.co.za", myLink = "~/HTML/Person02.html" });
            people.Add(new Models.Student { StudentNumber = "u25894092", FirstName = "Kattie", LastName = "Smit", EmailAddress = "u25894092@tuks.co.za", myLink = "~/HTML/Person03.html" });
            people.Add(new Models.Student { StudentNumber = "u18475629", FirstName = "Vanesa", LastName = "Dube", EmailAddress = "u18475629@tuks.co.za", myLink = "~/HTML/Person04.html" });

            return View(people);
        }
    }
}