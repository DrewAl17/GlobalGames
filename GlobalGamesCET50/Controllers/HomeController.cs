using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalGamesCET50.Models;
using GlobalGamesCET50.Dadoss;

namespace GlobalGamesCET50.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Inscricoes()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
