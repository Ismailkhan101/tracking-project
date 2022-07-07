using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class MakeController : Controller
    {
        private readonly VehicleTrackingERPDBContext _context;

        public MakeController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }





        public IActionResult Index()
        {

            List<Make> Makes = _context.Makes.ToList();
            return View(Makes);

        }


        public IActionResult MakeCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult MakeCreate(Make make)
        {

            if ((make.MakeName != null))
            {
                _context.Makes.Add(make);
                _context.SaveChanges();

            }
            else
            {
                ViewBag.mes = "Please enter make";
            }


            return RedirectToAction("Index");
        }

        private Make GetMake(int id)
         {
           Make Make = _context.Makes.FirstOrDefault(u => u.Id == id);
             return Make;
         }

        public IActionResult MakeUpdate(int id)
        {
          Make Make = GetMake(id);
           return View(Make);
      }

       [HttpPost]
        public IActionResult MakeUpdate(Make Make)
        {
          
               _context.Makes.Attach(Make);
               _context.Entry(Make).State = EntityState.Modified;
              _context.SaveChanges();
          
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            Make Make = _context.Makes.Where(x => x.Id == id).FirstOrDefault();
            return View(Make);
        }

        [HttpPost]
        public IActionResult Delete(Make Make)
        {
           
                _context.Makes.Attach(Make);
                _context.Entry(Make).State = EntityState.Deleted;
                _context.SaveChanges();
           
            return RedirectToAction("index");
        }
    }
}
