using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<JobOpening> allJobs = JobOpening.GetAll();
            return View(allJobs);
        }

        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create (string title, string description, int pay, string name, string email, string phone)
        {
            JobOpening newJobOpening = new JobOpening(title, description, pay, name, email,phone);
            return RedirectToAction("Index");
        }

    }

}