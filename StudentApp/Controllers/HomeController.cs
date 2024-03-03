using StudentApp.BAL.BusinessLogic;
using StudentApp.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        StudentBusinessLogic studentBusinessLogic = new StudentBusinessLogic();
        public ActionResult Index()
        { 
            return View(studentBusinessLogic.GetStudents());
        }

       

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }




        [HttpPost]
        public ActionResult Create(StudentDto student)
        {
            studentBusinessLogic.AddStudent(student); 
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {  

            return View(studentBusinessLogic.GetStudent(id));
        }




        [HttpPost]
        public ActionResult Edit(StudentDto student)
        {
            studentBusinessLogic.UpdateStudent(student); 
            return RedirectToAction("Index");
        }







        public ActionResult Delete(int id)
        {  
            return View(studentBusinessLogic.GetStudent(id));
        }




        [HttpPost]
        public ActionResult Delete(StudentDto student)
        {
            studentBusinessLogic.Delete(student);
            ViewBag.Message = "Your application description page.";
            return RedirectToAction("Index");
        }

    }
}