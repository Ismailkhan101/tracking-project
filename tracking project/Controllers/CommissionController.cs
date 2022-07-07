using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class CommissionController : Controller
    {
        private readonly VehicleTrackingERPDBContext _context;

        public CommissionController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Comission> Comissions = _context.Comissions.ToList();
            return View(Comissions);

        }


        public IActionResult CommissionCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CommissionCreate(Comission Comission)
        {


            _context.Comissions.Add(Comission);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        // it shows the details of customer vehicles
        private Comission GetComission(int id)
        {
            Comission Comission = _context.Comissions.FirstOrDefault(u => u.CommisionId == id);
            return Comission;
        }

      

        public IActionResult CommissionUpdate(int id)
        {
            Comission Comission = GetComission(id);
            return View(Comission);
        }

        [HttpPost]
        public IActionResult CommissionUpdate(Comission Comission)
        {
          
                _context.Comissions.Attach(Comission);
                _context.Entry(Comission).State = EntityState.Modified;
                _context.SaveChanges();
           
            return RedirectToAction("Index");
        }
        public IActionResult ComissionDelete(int id)
        {
            Comission Comission = GetComission(id);
            return View(Comission);
        }

        [HttpPost]
        public IActionResult ComissionDelete(Comission Comission)
        {
           
                _context.Comissions.Attach(Comission);
                _context.Entry(Comission).State = EntityState.Deleted;
                _context.SaveChanges();
           
            
            return RedirectToAction("index");
        }
    }
}
