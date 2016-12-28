using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vulop.Models;

namespace Vulop.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View(new Service[] { new Models.Service() {
                Duration = TimeSpan.FromMinutes(15),
                Description = "Teste"
            } });
        }

        public ActionResult ShowAdd()
        {
            throw new NotImplementedException();
        }
    }
}