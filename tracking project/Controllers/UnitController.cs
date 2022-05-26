using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class UnitController : Controller
    {
          
        private readonly VehicleTrackingERPDBContext _context;

        public UnitController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<UnitVehicle> UnitVehicles = _context.UnitVehicles.ToList();
            return View(UnitVehicles);

        }
        public IActionResult UnitVehicleCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult UnitVehicleCreate(UnitVehicle UnitVehicles)
        {

           
                _context.UnitVehicles.Add(UnitVehicles);
                _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        private UnitVehicle GetUnitVehicle(string id)
        {
            UnitVehicle UnitVehicle = _context.UnitVehicles.FirstOrDefault(u => u.UnitId.Equals(id));
            return UnitVehicle;
        }

        public IActionResult UnitVehicleDetails(string id)
        {
            UnitVehicle UnitVehicles = GetUnitVehicle(id);
            return View(UnitVehicles);
        }
        public IActionResult UnitVehicalUpdate(string id)
        {
            List<Customer> li = new List<Customer>();
            li = _context.Customers.ToList();

            ViewBag.listod = li;
            List<CustomerVehicle> VehicleId = new List<CustomerVehicle>();
            VehicleId = _context.CustomerVehicles.ToList();

            ViewBag.UnitId = VehicleId;
            UnitVehicle UnitVehicle = GetUnitVehicle(id);
            return View(UnitVehicle);
        }

        [HttpPost]
        public IActionResult UnitVehicalUpdate(UnitVehicle UnitVehicle)
        {
            try
            {
                _context.UnitVehicles.Attach(UnitVehicle);
                _context.Entry(UnitVehicle).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }
        public IActionResult UnitVehicalDelete(string id)
        {
           UnitVehicle UnitVehicle = GetUnitVehicle(id);
            return View(UnitVehicle);
        }
        [HttpPost]
        public IActionResult UnitVehicalDelete(UnitVehicle UnitVehicle)
        {
           
                _context.UnitVehicles.Attach(UnitVehicle);
                _context.Entry(UnitVehicle).State = EntityState.Deleted;
                _context.SaveChanges();
           
            return RedirectToAction("index");
        }
    }
}
