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
    public class TechnicianController : Controller
    {
        private readonly VehicleTrackingERPDBContext _context;

        public TechnicianController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }





        public IActionResult Index()
        {

            List<Technician> Technicians = _context.Technicians.ToList();
            return View(Technicians);

        }


        public IActionResult TechniciansCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult TechniciansCreate(Technician Technicians)
        {


            _context.Technicians.Add(Technicians);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private Technician GetTechnicians(int id)
         {
            Technician Technician = _context.Technicians.FirstOrDefault(u => u.Id == id);
             return Technician;
         }

        public IActionResult TechniciansUpdate(int id)
        {
            Technician Technicians = GetTechnicians(id);
           return View(Technicians);
      }

       [HttpPost]
        public IActionResult TechniciansUpdate(Technician Technicians)
        {
          
               _context.Technicians.Attach(Technicians);
               _context.Entry(Technicians).State = EntityState.Modified;
              _context.SaveChanges();
          
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            Technician Technicians = _context.Technicians.Where(x => x.Id == id).FirstOrDefault();
            return View(Technicians);
        }

        [HttpPost]
        public IActionResult Delete(Technician Technicians)
        {
           
                _context.Technicians.Attach(Technicians);
                _context.Entry(Technicians).State = EntityState.Deleted;
                _context.SaveChanges();
           
            return RedirectToAction("index");
        }
    }
}
