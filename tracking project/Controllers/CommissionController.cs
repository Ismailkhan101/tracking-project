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
        private CustomerVehicle GetCustomerVehicle(int id)
        {
            CustomerVehicle CustomerVehicles = _context.CustomerVehicles.FirstOrDefault(u => u.VehicalId == id);
            return CustomerVehicles;
        }

        public IActionResult CustomerVehicleDetails(int id)
        {
            CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
            return View(CustomerVehicles);
        }

        public IActionResult CustomerVehicalUpdate(int id)
        {
            CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
            return View(CustomerVehicles);
        }

        [HttpPost]
        public IActionResult CustomerVehicalUpdate(CustomerVehicle CustomerVehicles)
        {
            try
            {
                _context.CustomerVehicles.Attach(CustomerVehicles);
                _context.Entry(CustomerVehicles).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }
        public IActionResult CustomerVehicalDelete(int id)
        {
            CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
            return View(CustomerVehicles);
        }

        [HttpPost]
        public IActionResult CustomerVehicalDelete(CustomerVehicle CustomerVehicles)
        {
            try
            {
                _context.CustomerVehicles.Attach(CustomerVehicles);
                _context.Entry(CustomerVehicles).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("index");
        }
    }
}
