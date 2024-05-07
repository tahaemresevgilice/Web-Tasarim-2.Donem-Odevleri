using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using web14.Models;

namespace web14.Controllers
{
    public class AdminController : Controller
    {
        private readonly WbContext context;
        public AdminController(WbContext context)
        {
            this.context = context;
        }
        [Route("/Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registery()
        {
            return View(context.Registers.ToList());
        }
        public IActionResult Add()
        {
            SelectList kategoriler = new SelectList(context.Uyetipi, "Id", "Uyetipi");
            ViewBag.Kategoriler = kategoriler;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Register model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Registers.Add(model);
            context.SaveChanges();
            return RedirectToAction("Registery");
        }
        public IActionResult Update(int id)
        {
            Register ?kayit = context.Registers.FirstOrDefault(x=>x.Id==id);
            return View(kayit);
        }
        [HttpPost]
        public IActionResult Update(Register model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Registers.Update(model);
            context.SaveChanges();
            return RedirectToAction("Registery");
        }
        public IActionResult Delete(int id)
        {
            Register ?kayit = context.Registers.FirstOrDefault(x => x.Id == id);
            context.Registers.Remove(kayit);
            context.SaveChanges();
            return RedirectToAction("Registery");
        }
        public IActionResult Uyetipi()
        {
            return View();
        }
        public IActionResult UyetipiAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UyetipiAdd(UyeTipi model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Uyetipi.Add(model);
            context.SaveChanges();
            return RedirectToAction("Uyetipi");
        }
        public IActionResult UyetipiUpdate(int id)
        {
            UyeTipi ?kayit = context.Uyetipi.FirstOrDefault(x=>x.Id==id);
            return View(kayit);
        }
        [HttpPost]
        public IActionResult UyetipiUpdate(UyeTipi model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Uyetipi.Update(model);
            context.SaveChanges();
            return RedirectToAction("Uyetipi");
        }
        public IActionResult UyetipiDelete(int id)
        {
            UyeTipi ?kayit = context.Uyetipi.FirstOrDefault(x => x.Id == id);
            context.Uyetipi.Remove(kayit);
            context.SaveChanges();
            return RedirectToAction("Uyetipi");
        }

    }
}
