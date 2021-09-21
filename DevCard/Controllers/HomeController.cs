using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _Services = new List<Service>
        {
                new Service(1 , "a"),
                new Service(2 , "b"),
                new Service(3 , "c"),
                new Service(4 , "d")
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_Services,"ID","Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست، لطفا دوباره تلاش کنید";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact()
            {
                Services = new SelectList(_Services, "ID", "Name")
            };

            ViewBag.success = "اطلاعات وارد شده با موفقیت ثبت گردید";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
