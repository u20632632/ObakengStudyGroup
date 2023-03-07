using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObakengStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult ObakengStudyGroupView()
        {
            List<Models.PeopleClass> people = new List<Models.PeopleClass>();

            people.Add(new Models.PeopleClass { StudentNumber = "u12345678", Name = "Jane", Surname = "Doe", EmailAddress = "jane.Doe@tuks.co.za" });
            people.Add(new Models.PeopleClass { StudentNumber = "u01234567", Name = "John", Surname = "Darn", EmailAddress = "john.Darn@tuks.co.za" });
            people.Add(new Models.PeopleClass { StudentNumber = "u11234567", Name = "Terrence", Surname = "straught", EmailAddress = "Terrence.straught@tuks.co.za" });
            people.Add(new Models.PeopleClass { StudentNumber = "u12234567", Name = "Angel", Surname = "Shileyi", EmailAddress = "Angel.Shileyi@tuks.co.za" });
            people.Add(new Models.PeopleClass { StudentNumber = "u12345677", Name = "Mike", Surname = "Vactor", EmailAddress = "Mike.Vactor@tuks.co.za" });


            return View(people);

        }
    }
}