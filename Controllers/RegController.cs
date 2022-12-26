using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Travello.Models;
namespace Travello.Controllers
{
    public class RegController : Controller
    {
        [HttpGet("/Reg")]
        public ActionResult RegIndex(){

            return View();
        }
        [HttpPost("/Reg")]
        public ActionResult RegIndex(User u)
        {

            return Content(u.Username+"\n"+u.Password+"\n "+u.Email+"\n "+u.Phonenumber);

        }
    }
}
