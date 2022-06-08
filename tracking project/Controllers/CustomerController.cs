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

            var dueAmount = (from v in c.Vehicles
                             where v.DueDate < DateTime.Now
                             select v.Net).ToList();
            double totalAmount = 0;
            foreach (var item in dueAmount)
            {
                totalAmount = totalAmount + item;
            }

            var vehiclesdecidedAMF = from v in c.Vehicles
                             select new { v.VehicalId, v.DecidedAMF };

            //vehiclesdecidedAMF.Select(x=>x.DecidedAMF)

            List<InvoiceYearly> invoices = new List<InvoiceYearly>();

            foreach (var item in _context.InvoiceYearly)
            {
                foreach (var item2 in vehiclesdecidedAMF)
                {
                    if(item.VehicalId == item2.VehicalId && item.ExpiryDate < DateTime.Now)
                    {
                        invoices.Add(item);
                    }
                }
            }

            var q = from x in invoices
                    group x by x.VehicalId into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            double yearAmount = 0;

            foreach (var item in q)
            {
                foreach(var item2 in vehiclesdecidedAMF)
                {
                    if(item.Value == item2.VehicalId)
                    {
                        yearAmount = yearAmount + (item.Count * item2.DecidedAMF);
                    }
                }
            }

            double totalInvoice = yearAmount + totalAmount;

           

            ViewBag.TotalAmount = totalInvoice;


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

            List<UnitVehicle> Units = new List<UnitVehicle>();
            Units = _context.UnitVehicles.ToList();

            ViewBag.UnitId = Units;
            List<SalePerson> SalePerson = new List<SalePerson>();
            SalePerson = _context.SalePersons.ToList();
            ViewBag.SalePerson = SalePerson;


            return View();
        }
        [HttpPost]
        public IActionResult CustomerVehicleCreate(CustomerVehicle customerVehicles,double Commission,int Agent)
        {
            customerVehicles.CustomerID= customerVehicles.Customer.CustomerId;
            customerVehicles.Customer = null;
            customerVehicles.Net = 5;
            customerVehicles.Balance = 5;
            _context.CustomerVehicles.Add(customerVehicles);
            _context.SaveChanges();

            UnitVehicle unitVehicle = _context.UnitVehicles.Where(x => x.UnitId.Equals(customerVehicles.unitId)).FirstOrDefault();
            unitVehicle.VehicleId = customerVehicles.VehicalId;
            unitVehicle.InstallationDate = DateTime.Now;
            unitVehicle.Status = true;
           /* unitVehicle.FreshExpiry = DateTime.Now.AddYears(1);*/
            _context.Entry(unitVehicle).State = EntityState.Modified;

            InvoiceYearly invoice = new InvoiceYearly();
            invoice.ValidFromDate = DateTime.Now;
            invoice.ExpiryDate = DateTime.Now.AddYears(1);
            invoice.AmfStatus = false;
            invoice.YearlyPaymentStatus = true;
            invoice.Year = DateTime.Now;
            invoice.VehicalId = customerVehicles.VehicalId;
            _context.InvoiceYearly.Add(invoice);
            _context.SaveChanges();

            Comission com = new Comission();
            com.Commission = Commission;
            com.CommissionType = "Vehicle for Request";
            com.VehicleId = customerVehicles.VehicalId; ;
            com.SalePersonId =Convert.ToInt32( Agent); 
            // sale person id
            // comssion value
            _context.Comissions.Add(com);
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
            CustomerVehicles.Net = 5;
            CustomerVehicles.Balance = 5;
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
            List<Customer> li = new List<Customer>();
            li = _context.Customers.ToList();

            ViewBag.listod = li;
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
