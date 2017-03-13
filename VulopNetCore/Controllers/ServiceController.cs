using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VulopNetCore.Data;
using Microsoft.EntityFrameworkCore;

namespace VulopNetCore.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Models.Service> services = _context.Services.Select(s => new Models.Service()
            {
                ID = s.ID,
                Description = s.Description,
                Duration = s.Duration 
            }); 
            return View(services);
        }

        // GET
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _context.Services.SingleOrDefault(m => m.ID == id);
            if (service == null)
            {
                return NotFound();
            }

            var modelService = new Models.Service()
            {
                ID = service.ID,
                Description = service.Description,
                Duration = service.Duration
            };

            return View(modelService);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = _context.Services.SingleOrDefault(m => m.ID == id);
            if (service == null)
            {
                return NotFound();
            }

            var modelService = new Models.Service()
            {
                ID = service.ID,
                Description = service.Description,
                Duration = service.Duration
            };

            return View(modelService);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,Description,Duration")] Models.Service service)
        {
            if (id != service.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Service svc = _context.Services.SingleOrDefault(s => s.ID == id);
                    if (svc == null)
                    {
                        return NotFound();
                    }
                    svc.Description = service.Description;
                    svc.Duration = service.Duration;

                    _context.Update(svc);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(service);
        }
    }
}