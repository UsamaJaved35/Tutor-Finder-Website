using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutor_Finder.Models;

namespace Tutor_Finder.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult LoginTutor()
        {
            return View("LoginTutor");
        }
        [HttpPost]
        public ViewResult LoginTeacher(Tutor t)
        {
            TutorRepository tr = new TutorRepository();
            if (tr.Login(t))
                return View("Welcome");
            else
                return View("Error");
        }
        [HttpGet]
        public ViewResult LoginStudent()
        {
            return View("LoginStudent");
        }
        [HttpPost]
        public ViewResult LoginStudent(Student s)
        {
            StudentRepository sr = new StudentRepository();
            if (sr.Login(s))
                return View("Welcome");
            else
                return View("Error");
        }
    }
}
