using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

[Route("Login")] 

    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

