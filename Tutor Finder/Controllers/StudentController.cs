﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutor_Finder.Models;

namespace Tutor_Finder.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult StudentForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult StudentForm(Student s)
        {
            StudentRepository sr = new StudentRepository();
            if (ModelState.IsValid)
            {
                if (sr.AddStudent(s))
                    return View("Welcome");
                else
                    return View("Error");
            }
            else
                return View();
        }
        public ViewResult Welcome()
        {
            return View();
        }
        public ViewResult Error()
        {
            return View();
        }
    }
}
