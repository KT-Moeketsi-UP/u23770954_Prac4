using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S1P04.Controllers
{
    public class PeopleController : Controller
    {
        //GET: People
        public static List<Models.PersonModel> people = new List<Models.PersonModel>();
        public ActionResult ListPeople()
        {


            people.Add(new Models.PersonModel
            {
                StuNumber = "u0001",
                FirstName = "Person 1",
                LastName = "Surname 1",
                Email = "person1@tuks.co.za",
                myLink = "~/HTMLPages/Person01.html"
            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u0002",
                FirstName = "Sameer",
                LastName = "Surname 2",
                Email = "person2@tuks.co.za",
                myLink = "~/HTMLPages/Person02.html"
            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u0003",
                FirstName = "Person 3",
                LastName = "Surname 3",
                Email = "person3@tuks.co.za",
                myLink = "~/HTMLPages/Person03.html"
            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u0004",
                FirstName = "Person 4",
                LastName = "Surname 4",
                Email = "person4@tuks.co.za",
                myLink = "~/HTMLPages/Person04.html"
            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u0005",
                FirstName = "Person 5",
                LastName = "Surname 5",
                Email = "person5@tuks.co.za",
                myLink = "~/HTMLPages/Person05.html"
            });

            return View(people);
        }

        
        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PersonModel pm)
        {
            people.Add(new Models.PersonModel { FirstName = pm.FirstName, LastName = pm.LastName, Email = pm.Email,  StuNumber = pm.StuNumber });
            return RedirectToAction("ListPeople");

        }
    }
}