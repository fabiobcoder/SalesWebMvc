using System.Collections.Generic;
using SalesWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Deparment> list = new List<Deparment>();
            list.Add(new Deparment { Id = 1, Name = "Eletronics" });
            list.Add(new Deparment { Id = 2, Name = "Fashion" });

            return View();
        }
    }
}
