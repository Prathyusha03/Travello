using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travello.Models;
namespace Travello.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet("/Login")]
        public ActionResult LoginIndex()
        {
           
            return View();
        }
        [HttpPost("/Login")]
        public ActionResult LoginIndex(User u)
        {

            return Content(u.Username);
        }
    }
}
