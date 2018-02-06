using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Form()
        {
            return View("Index");
        }

        [HttpPost("/JobOpening")]
        public ActionResult CreateJobOpening()
        {
            JobOpening myJobOpening = new JobOpening();
            myJobOpening.SetTitle(Request.Form["job-title"]);
            myJobOpening.SetDesc(Request.Form["job-desc"]);
            myJobOpening.SetPay(Request.Form["job-pay"]);
            myJobOpening.Save();
            return View("JobOpening", myJobOpening);
        }

        [HttpGet("/JobBoard")]
        public ActionResult JobBoard()
        {
            JobOpening myJobOpening = new JobOpening();
            List<JobOpening> myJobList = JobOpening.GetJobOpenings();
            return View(myJobList);
        }

        [HttpGet("/ClearJobBoard")]
        public ActionResult ClearJobBoard()
        {
            JobOpening.ClearList();
            return View("JobBoard");
        }
    }
}
