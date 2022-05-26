using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class CustomerController : Controller
    {
        // this statment display the recordes of customers  
        private readonly VehicleTrackingERPDBContext _context;

        public CustomerController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }
        public  IActionResult Index()
        {

            List<Customer> Customers= _context.Customers.Include(x=>x.SalePerson).ToList();
            return View(Customers);

        }
        
        // selecting customer vehicles
        public IActionResult CustomerVehicleSelect(int id)
        {
            Customer c = _context.Customers.Include(x => x.Vehicles).SingleOrDefault(x => x.CustomerId == id);
           
            return View(c);

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
        //submitt data into customer vehicle
        public IActionResult CustomerVehicleCreate(int id)
        {
            ViewBag.Id = id;
            List<Customer> li = new List<Customer>();
            li = _context.Customers.ToList();

            ViewBag.listod = li;

            List<UnitVehicle> UnitId = new List<UnitVehicle>();
            UnitId = _context.UnitVehicles.ToList();

            ViewBag.UnitId = UnitId;


            return View();
        }
        [HttpPost]
        public IActionResult CustomerVehicleCreate(CustomerVehicle customerVehicles)
        {
            customerVehicles.CustomerID = customerVehicles.Customer.CustomerId;
            customerVehicles.Customer = null;
            _context.CustomerVehicles.Add(customerVehicles);
            _context.SaveChanges();

            UnitVehicle unitVehicle = _context.UnitVehicles.Where(x => x.UnitId.Equals(customerVehicles.unitId)).FirstOrDefault();
            unitVehicle.VehicleId = customerVehicles.VehicalId;
            unitVehicle.InstallationDate = DateTime.Now;
            unitVehicle.Status = true;
            unitVehicle.FreshExpiry = DateTime.Now.AddYears(1);
            _context.Entry(unitVehicle).State = EntityState.Modified;
            _context.SaveChanges();


            return RedirectToAction("CustomerVehicleSelect", "Customer", new { @id = customerVehicles.CustomerID });
        }
        public IActionResult CustomerVehicalUpdate(int id)
        {
            List<UnitVehicle> UnitId = new List<UnitVehicle>();
            UnitId = _context.UnitVehicles.ToList();

            ViewBag.UnitId = UnitId;
            CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
            return View(CustomerVehicles);

        }

        [HttpPost]
        public IActionResult CustomerVehicalUpdate(CustomerVehicle CustomerVehicles)
        {
            
            _context.CustomerVehicles.Attach(CustomerVehicles);
            _context.Entry(CustomerVehicles).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("CustomerVehicleSelect", "Customer", new { @id = CustomerVehicles.CustomerID });
        }
        public IActionResult CustomerVehicalDelete(int id)
        {
            CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
            return View(CustomerVehicles);
        }

        [HttpPost]
        public IActionResult CustomerVehicalDelete(CustomerVehicle CustomerVehicles)
        {
         
                _context.CustomerVehicles.Attach(CustomerVehicles);
                _context.Entry(CustomerVehicles).State = EntityState.Deleted;
                _context.SaveChanges();
         
            return RedirectToAction("index");
        }

        // insert  into customer table

        public IActionResult Customercreate()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CustomerCreate(Customer Customer)
        {

            try
            {
                _context.Customers.Add(Customer);
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }

        // it shows the details of customer
        private Customer GetCustomer(int id)
        {
            Customer Customer = _context.Customers.FirstOrDefault(u => u.CustomerId == id);
            return Customer;
        }

        public IActionResult CustomerDetails(int id)
        {
            Customer Customer = GetCustomer(id);
            CustomerVehicleSelect(id);

            return View(Customer);
        }
        //it is used to update customer records
        public IActionResult EditCustomer(int id)
        {
            Customer Customer = GetCustomer(id);
            return View(Customer);
        }

        [HttpPost]
        public IActionResult EditCustomer(Customer Customer)
        {
            try
            {
                _context.Customers.Attach(Customer);
                _context.Entry(Customer).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }

        // it is used to delete customer records
        public IActionResult DeleteCustomer(int id)
        {
            Customer Customer = GetCustomer(id);
            return View(Customer);
        }

        [HttpPost]
        public IActionResult DeleteCustomer(Customer Customer)
        {
            try
            {
                _context.Customers.Attach(Customer);
                _context.Entry(Customer).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("index");
        }
    }
}
