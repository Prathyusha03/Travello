using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travello.Controllers
{
    public class WelcomeController : Controller
    {
        public ActionResult WelcomeIndex()
        {
            return View();
        }
        
    }
}
