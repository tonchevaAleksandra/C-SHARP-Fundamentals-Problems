using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPNETCoreAppDemo.Controllers
{
    public class ToDoController: Controller
    {
        public IActionResult Index()
        {
            ViewBag.HelloMessage = "Welcome to /ToDo/Index";
            return View();
        }
    }
}
