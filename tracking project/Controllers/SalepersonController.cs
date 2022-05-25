using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class SalepersonController : Controller
    {
        // to display sale person recordes 
        private readonly VehicleTrackingERPDBContext _context;

        public SalepersonController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<SalePerson> SalePersons = _context.SalePersons.ToList();
            return View(SalePersons);
            
        }
        // it is used for insertion of sale person 
        public IActionResult CreateSalePerson()
        {
            SalePerson SalePersons = new SalePerson();
            return View(SalePersons);
        }
        [HttpPost]
        public IActionResult CreateSalePerson(SalePerson SalePersons)
        {

            try
            {
                _context.SalePersons.Add(SalePersons);
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        // it is showing details of sale person
        private SalePerson GetSalePerson(int id)
        {
            SalePerson SalePersons = _context.SalePersons.FirstOrDefault(u => u.SalePersonId == id);
            return SalePersons;
        }

        public IActionResult DetailsSalePerson(int id)
        {
            SalePerson SalePersons = GetSalePerson(id);
            return View(SalePersons);
        }
        //this is updateing sale person records
        public IActionResult UpdateSalePerson(int id)
        {
            SalePerson SalePersons = GetSalePerson(id);
            return View(SalePersons);
        }

        [HttpPost]
        public IActionResult UpdateSalePerson(SalePerson SalePersons)
        {
            try
            {
                _context.SalePersons.Attach(SalePersons);
                _context.Entry(SalePersons).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }

        // delete sale person record
        public IActionResult DeleteSalePerson(int id)
        {
            SalePerson SalePersons = GetSalePerson(id);
            return View(SalePersons);
        }

        [HttpPost]
        public IActionResult DeleteSalePerson(SalePerson SalePersons)
        {
           
                _context.SalePersons.Attach(SalePersons);
                _context.Entry(SalePersons).State = EntityState.Deleted;
                _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        // selecting customer vehicles
        public IActionResult SalePersonVehicleSelect(int id)
        {
            SalePerson c = _context.SalePersons.Include(x=>x.Customers).SingleOrDefault(x => x.SalePersonId == id);

            //List<CustomerVehicle> CustomerVehicles = _context.CustomerVehicles.Where(x => x.SalePerson.SalePersonId == id).ToList();


            //var cvViewModel = new SalePersonVehicleVM
            //{
            //    SalePerson = c,
            //    Vehicles = CustomerVehicles
            //};
            return View(c);

        }

        //submitt data into customer vehicle
        public IActionResult SalePersonCustomerCreate(int id)
        {
            ViewBag.Id = id;
            List<SalePerson> li = new List<SalePerson>();
            li = _context.SalePersons.ToList();

            ViewBag.listod = li;


            return View();
        }
        [HttpPost]
        public IActionResult SalePersonCustomerCreate(Customer Customer)
        {

           
            
                _context.Customers.Add(Customer);
                _context.SaveChanges();
            
           
            return RedirectToAction("Index");
        }
        private Customer GetCustomer(int id)
        {
            Customer Customer = _context.Customers.FirstOrDefault(u => u.CustomerId == id);
            return Customer;
        }
        //it is used to update customer records
        public IActionResult SalePersonCustomerUpdate(int id)
        {
            Customer Customer = GetCustomer(id);
            return View(Customer);
        }

        [HttpPost]
        public IActionResult SalePersonCustomerUpdate(Customer Customer)
        {
           
                _context.Customers.Attach(Customer);
                _context.Entry(Customer).State = EntityState.Modified;
                _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        // it is used to delete customer records
        public IActionResult SalePersonCustomerDelete(int id)
        {
            Customer Customer = GetCustomer(id);
            return View(Customer);
        }

        [HttpPost]
        public IActionResult SalePersonCustomerDelete(Customer Customer)
        {
           
                _context.Customers.Attach(Customer);
                _context.Entry(Customer).State = EntityState.Deleted;
                _context.SaveChanges();
           
            return RedirectToAction("index");
        }
    }
}
