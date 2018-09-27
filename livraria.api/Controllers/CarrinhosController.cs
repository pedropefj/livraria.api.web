using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace livraria.api.Controllers
{
    public class CarrinhosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}