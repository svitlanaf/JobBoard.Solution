using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;


namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
