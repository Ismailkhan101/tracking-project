using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class InvoiceYearlyController : Controller
    {
      

        private readonly VehicleTrackingERPDBContext _context;
        private readonly VehicleTrackingERPDBContext _context2;

        public InvoiceYearlyController(VehicleTrackingERPDBContext context, VehicleTrackingERPDBContext context2)
        {
            _context = context;
            _context2 = context2;
        }
        public IActionResult Index(int id)
        {
            ViewBag.AMF = _context.CustomerVehicles.Where(x => x.VehicalId == id).FirstOrDefault().DecidedAMF;
            ViewBag.vehicleID= _context.CustomerVehicles.Where(x => x.VehicalId == id).FirstOrDefault().VehicalId;
            var data = _context.InvoiceYearly.Include(x=>x.CustomerVehicle).Where(x=>x.VehicalId == id).ToList();
            return View(data);

        }
       
        public IActionResult Create(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InvoiceYearly invoice)
        {
            invoice.ValidFromDate = DateTime.Now;
            invoice.ExpiryDate = DateTime.Now.AddYears(1);
            invoice.VehicalId = invoice.Id;
            invoice.Id = 0;

            var AMF = _context.CustomerVehicles.Where(x => x.VehicalId == invoice.VehicalId).FirstOrDefault().DecidedAMF;

            invoice.BalanceAmount = invoice.ReceivedAmount - AMF - invoice.Tax;
            
            _context.InvoiceYearly.Add(invoice);
            _context.SaveChanges();

            return RedirectToAction("Index", "InvoiceYearly", new { id = invoice.VehicalId });
        }


        public IActionResult Details(int id)
        {
            InvoiceYearly invoice = _context.InvoiceYearly.Where(x => x.Id == id).FirstOrDefault();
            CustomerVehicle vehicle = _context.CustomerVehicles.Where(x => x.VehicalId == invoice.VehicalId).FirstOrDefault();
            invoice.CustomerVehicle = vehicle;

            Customer cus = _context.Customers.Where(x => x.CustomerId == vehicle.CustomerID).FirstOrDefault();
            invoice.CustomerVehicle.Customer = cus;
            return View(invoice);
        }
        private InvoiceYearly GetInvoiceYearly(int id)
        {
            InvoiceYearly InvoiceYearlies = _context.InvoiceYearly.FirstOrDefault(u => u.Id == id);
            return InvoiceYearlies;
        }
        public IActionResult InvoiceYearlyUpdate(int id)
        {
           InvoiceYearly InvoiceYearlies = GetInvoiceYearly(id);
            return View(InvoiceYearlies);
        }

        [HttpPost]
        public IActionResult InvoiceYearlyUpdate(InvoiceYearly InvoiceYearlies)
        {
           
                _context.InvoiceYearly.Attach(InvoiceYearlies);
                _context.Entry(InvoiceYearlies).State = EntityState.Modified;
                _context.SaveChanges();
            
            return RedirectToAction("Index", "InvoiceYearly", new { id = InvoiceYearlies.VehicalId });
        }
        public IActionResult InvoiceYearlyDelete(int id)
        {
            InvoiceYearly InvoiceYearly = GetInvoiceYearly(id);
            return View(InvoiceYearly);
        }

        [HttpPost]
        public IActionResult InvoiceYearlyDelete(InvoiceYearly InvoiceYearly, int vehicle)
        {
            InvoiceYearly = _context.InvoiceYearly.Where(x => x.Id == InvoiceYearly.Id).FirstOrDefault();
            int? vechileid = InvoiceYearly.VehicalId;
            //var data = _context2.InvoiceYearly.Where(x => x.Id == InvoiceYearly.Id).FirstOrDefault();
            //var vehicle = _context2.CustomerVehicles.Where(x => x.VehicalId == data.VehicalId).FirstOrDefault().VehicalId;
            _context.InvoiceYearly.Attach(InvoiceYearly);
            _context.Entry(InvoiceYearly).State = EntityState.Deleted;
            _context.SaveChanges();

            return RedirectToAction("Index", "InvoiceYearly", new { id = vechileid });
        }
    }
    
}
