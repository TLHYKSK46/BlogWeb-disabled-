using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebUI.Controllers
{
    public class MakaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
