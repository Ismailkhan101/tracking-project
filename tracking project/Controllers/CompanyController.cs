using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class CompanyNameController : Controller
    {
        // To display the recordes of customer vehicle  
        private readonly VehicleTrackingERPDBContext _context;

        public CompanyNameController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Company> CompanyNames = _context.Company.ToList();
            return View(CompanyNames);

    }


        public IActionResult CompanyCreate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CompanyCreate(Company Company)
        {


            _context.Company.Add(Company);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        // it shows the details of customer vehicles
        /* private CustomerVehicle GetCustomerVehicle(int id)
         {
             CustomerVehicle CustomerVehicles = _context.CustomerVehicles.FirstOrDefault(u => u.VehicalId == id);
             return CustomerVehicles;
         }

         public IActionResult CustomerVehicleDetails(int id)
         {
             CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
             return View(CustomerVehicles);
         }*/

        /*public IActionResult CustomerVehicalUpdate(int id)
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
        }*/
    }
}
