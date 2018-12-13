using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoLoad.Models;
using Demo.IService;

namespace DemoLoad.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountService accountService;
        private readonly IProductService productService;

        public HomeController(IAccountService accountService, IProductService productService)
        {
            this.accountService = accountService;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            ViewData["AA"] = accountService.SayHello("AA");
            ViewData["BB"] = productService.SayHello("BB");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
