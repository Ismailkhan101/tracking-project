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

           /* var dueAmount = (from v in c.Vehicles
                             where v.DueDate < DateTime.Now && v.Balance < 0
                             select v.Balance).ToList();
            double totalAmount = 0;
            foreach (var item in dueAmount)
            {
                totalAmount = totalAmount + item;
            }*/

            /*  var vehiclesdecidedAMF = from v in c.Vehicles
                               select new { v.VehicalId, v.DecidedAMF };*/

            //vehiclesdecidedAMF.Select(x=>x.DecidedAMF)

            List<InvoiceYearly> invoices = new List<InvoiceYearly>();

            foreach (var item in _context.InvoiceYearly)
            {
               /* foreach (var item2 in vehiclesdecidedAMF)
                {
                    if(item.VehicalId == item2.VehicalId && item.ExpiryDate < DateTime.Now && item.BalanceAmount < 0)
                    {
                        invoices.Add(item);
                    }
                }*/
            }

            var q = from x in invoices
                    group x by x.VehicalId into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };

            double yearAmount = 0;

            foreach (var item in q)
            {
                /*foreach(var item2 in vehiclesdecidedAMF)
                {
                    if(item.Value == item2.VehicalId)
                    {
                        yearAmount = yearAmount + (item.Count * item2.DecidedAMF);
                    }
                }*/
            }

            /*double totalInvoice = yearAmount + totalAmount;*/

           

            /*ViewBag.TotalAmount = totalInvoice;*/


            return View(c);

        }


        [HttpGet]
        public IActionResult InvoiceDetails(int id)
        {
            Customer c = _context.Customers.Include(x => x.Vehicles).SingleOrDefault(x => x.CustomerId == id);

            List<int> vehicleID = c.Vehicles.Select(x => x.VehicalId).ToList();

           

            var freshPayments = _context.freshPayments.Include(x => x.Vehicle).Where(r => vehicleID.Any(id => id == r.VehicleID)).ToList();

            DateTime localDate = DateTime.Now;

            var dueFreshVehiclePayments = (from v in freshPayments
                             where v.DueDate < localDate && v.Balance < 0
                             orderby v.Vehicle.RegistrationNo
                             select v);

            InvoiceDetails invoiceDetails = new InvoiceDetails();
            invoiceDetails.freshPayments = dueFreshVehiclePayments;

            double freshVehicleAmounts = 0;

             

            foreach (var item in dueFreshVehiclePayments)
            {
                freshVehicleAmounts = freshVehicleAmounts + item.Balance;
            }

            invoiceDetails.freshVehicleAmounts = freshVehicleAmounts;


            var invoiceYeary = _context.InvoiceYearly.Where(x =>vehicleID.Contains((int)x.VehicalId)).ToList();
            var dueFinvoicePayments = (from v in invoiceYeary
                                           where v.ExpiryDate < localDate && v.BalanceAmount < 0
                                           orderby v select v);
            var invoiceAmounts = 0;
            foreach (var item in dueFinvoicePayments)
            {
                invoiceAmounts +=  Convert.ToInt32( item.BalanceAmount);
            }

            //var invoiceYeary = _context.InvoiceYearly.Include(x => x.CustomerVehicle).Where(r => vehicleID.Any(id => id == r.VehicalId)).ToList();

            //var invoiceYeary = _context.InvoiceYearly.Where(r => vehicleID.Any(id => id == r.VehicalId)).ToList();

           /* invoiceDetails.InvoiceYearly = invoiceAmounts;*/

            /* foreach (var item in invoiceYeary)
             {
                 invoiceDetails.totalYearlyInvoice = invoiceDetails.totalYearlyInvoice + item.BalanceAmount;
             }

             invoiceDetails.totalAmounntDue = invoiceDetails.totalYearlyInvoice + invoiceDetails.freshVehicleAmounts;
 */

            //var vehiclesdecidedAMF = from v in c.Vehicles
            //                         select new { v.VehicalId, v.DecidedAMF };

            //vehiclesdecidedAMF.Select(x => x.DecidedAMF);

            //List<InvoiceYearly> invoices = new List<InvoiceYearly>();

            //foreach (var item in _context.InvoiceYearly)
            //{
            //    foreach (var item2 in vehiclesdecidedAMF)
            //    {
            //        if (item.VehicalId == item2.VehicalId && item.ExpiryDate < DateTime.Now && item.BalanceAmount < 0)
            //        {
            //            invoices.Add(item);
            //        }
            //    }
            //}

            //invoiceDetails.InvoiceYearly = (from v in invoices
            //                                orderby v.VehicalId
            //                                select v).ToList();

            //var q = from x in invoices
            //        group x by x.VehicalId into g
            //        let count = g.Count()
            //        orderby count descending
            //        select new { Value = g.Key, Count = count };


            //double yearAmount = 0;

            //foreach (var item in q)
            //{
            //    foreach (var item2 in vehiclesdecidedAMF)
            //    {
            //        if (item.Value == item2.VehicalId)
            //        {
            //            yearAmount = yearAmount + (item.Count * item2.DecidedAMF);
            //        }
            //    }
            //}

            //invoiceDetails.totalYearlyInvoice = yearAmount;

            //double totalInvoice = yearAmount + freshVehicleAmounts;

            //invoiceDetails.totalAmounntDue = totalInvoice;


            return View(invoiceDetails);
        }


        // it shows the details of customer vehicles
        private CustomerVehicle GetCustomerVehicle(int id)
        {
            ViewBag.id = id;
            CustomerVehicle CustomerVehicles = _context.CustomerVehicles.FirstOrDefault(u => u.VehicalId == id);
            return CustomerVehicles;
        }
        private Make GetMakeModel(int id)
        {

            Make MDN = _context.Makes.FirstOrDefault(x => x.Id == id); ;
            return MDN;
        }

        public IActionResult CustomerVehicleDetails(int id)
        {
            ViewBag.Id = id;
            CustomerVehicle CustomerVehicles = GetCustomerVehicle(id);
          var MakeIdGet=Convert.ToInt32( CustomerVehicles.MakeModel);
            //only gettnt make mode name to display record
            CustomerVehicles.MakeModel = GetMakeModel(MakeIdGet).Name;
            


            return View(CustomerVehicles);
        }
        //submitt data into customer vehicle
        public IActionResult CustomerVehicleCreate(int id)
        {
            ViewBag.Id = id;
            List<Customer> li = new List<Customer>();
            li = _context.Customers.ToList();

            ViewBag.listod = li;
            List<Make> Makes = new List<Make>();
            Makes = _context.Makes.ToList();

            ViewBag.Make = Makes;

            List<Model> Models = new List<Model>();
            Models = _context.Models.ToList();
            
            ViewBag.Model = Models;
            List<UnitVehicle> Units = new List<UnitVehicle>();
            Units = _context.UnitVehicles.Where(x=>x.VehicleId == null).ToList();

            ViewBag.UnitId = Units;
            


            return View();
        }
        [HttpPost]
        public IActionResult CustomerVehicleCreate(CustomerVehicle customerVehicles)
        {
           // customerVehicles.CustomerID= customerVehicles.CustomerID;
           // customerVehicles.Customer = null;
            //customerVehicles.Net = 5;
           // customerVehicles.Balance = 5;
            _context.CustomerVehicles.Add(customerVehicles);
            _context.SaveChanges();
            // getting vehicle id
            
            if (customerVehicles.unitId != null)
            {
                UnitVehicle unitVehicle = _context.UnitVehicles.Where(x => x.UnitId.Equals(customerVehicles.unitId)).FirstOrDefault();
                unitVehicle.VehicleId = customerVehicles.VehicalId;
                unitVehicle.InstallationDate = DateTime.Now;
                unitVehicle.Status = true;
                /* unitVehicle.FreshExpiry = DateTime.Now.AddYears(1);*/
                _context.Entry(unitVehicle).State = EntityState.Modified;
            }
         
           


            return RedirectToAction("FreshCreate", "Customer", new { @VehicleID = customerVehicles.VehicalId });
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
            /*CustomerVehicles.Net = 5;
            CustomerVehicles.Balance = 5;*/
            _context.CustomerVehicles.Attach(CustomerVehicles);
            
            _context.Entry(CustomerVehicles).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("FreshPaymentUpdate", "Customer", new { @VehicleID = CustomerVehicles.VehicalId });
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

            ViewBag.company = _context.Company.ToList();
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

        public IActionResult ApplicationForm(int id)
        {
            var data = _context.Customers.Include(x => x.Vehicles).Where(x => x.CustomerId == id).FirstOrDefault();
            
            
            //var af=_context.freshPayments.Include(x=>x.VehicleID).Where(x=>x.VehicleID==data).
            //var a = _context.CustomerVehicles.Include(x => x.UnitVehicle).ToList();
            //a = (from v in a
            //         from c in data.Vehicles
            //         where v.VehicalId == c.VehicalId
            //         select v).ToList();
            //foreach (var v in data.Vehicles)
            //{

            //}
            
            return View(data);
        }

        // Fresh  PaymentCreate section
        public IActionResult FreshCreate(int VehicleId)
        {
            ;
           ViewBag.VehicleId = VehicleId;
            List<SalePerson> SalePerson = new List<SalePerson>();
            SalePerson = _context.SalePersons.ToList();
            ViewBag.SalePerson = SalePerson;
            return View();
        }
        [HttpPost]
        public IActionResult FreshCreate(FreshPayment FreshPayment,int Agent, bool GSTCheck, string ServiceTax)
        {

            if (GSTCheck == true)
            {
                FreshPayment._GST = ((FreshPayment.UnitCost) * 0.17);
            }
            else
            {
                FreshPayment._GST = 0;
            }
            

            if (ServiceTax == "BRA-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "SRB-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "PRA-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "KPRA-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "ICT-15%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.15);
            }
            else if (ServiceTax == "Zero")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0);
            }
            else
            {
                FreshPayment.ServiceTax = 0;
            }
            FreshPayment.Service = FreshPayment.ServiceTax;
            FreshPayment.Net = (FreshPayment.DecidedAMF+ FreshPayment.UnitCost)-FreshPayment._GST - FreshPayment.Commission - FreshPayment.ServiceTax - FreshPayment.Discount;
            FreshPayment.Invoice = FreshPayment.DecidedAMF + FreshPayment.UnitCost;
            FreshPayment.SalePersonID = Agent;
            _context.freshPayments.Add(FreshPayment);
            
            _context.SaveChanges();
            Comission com = new Comission();
            com.Commission = FreshPayment.Commission;
            com.CommissionType = "Vehicle for Request";
            com.VehicleId = FreshPayment.VehicleID ;
            com.SalePersonId = Convert.ToInt32(Agent);
            // sale person id
            // comssion value
            _context.Comissions.Add(com);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private FreshPayment GetFreshPayment(int id)
        {
            FreshPayment FreshPayment = _context.freshPayments.FirstOrDefault(u => u.VehicleID == id);
            return FreshPayment;
        }
        public IActionResult FreshPaymentUpdate(int id,int VehicleId)
        {
            ViewBag.VehicleId = VehicleId;
            FreshPayment FreshPayment = GetFreshPayment(VehicleId);
            return View(FreshPayment);
        }

        [HttpPost]
        public IActionResult FreshPaymentUpdate(FreshPayment FreshPayment, bool GSTCheck, string ServiceTax)
        {
            if (GSTCheck == true)
            {
                FreshPayment._GST = ((FreshPayment.UnitCost) * 0.17);
            }
            else
            {
                FreshPayment._GST = 0;
            }


            if (ServiceTax == "BRA-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "SRB-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "PRA-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "KPRA-19.5%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.195);
            }
            else if (ServiceTax == "ICT-15%")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0.15);
            }
            else if (ServiceTax == "Zero")
            {
                FreshPayment.ServiceTax = ((FreshPayment.DecidedAMF) * 0);
            }
           
            FreshPayment.Service = FreshPayment.ServiceTax;
            FreshPayment.Net = (FreshPayment.DecidedAMF + FreshPayment.UnitCost) - FreshPayment._GST - FreshPayment.Commission - FreshPayment.ServiceTax - FreshPayment.Discount;
            FreshPayment.Invoice = FreshPayment.DecidedAMF + FreshPayment.UnitCost;
            _context.freshPayments.Attach(FreshPayment);
            _context.Entry(FreshPayment).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult FreshPaymentDetails(int id)
        {
            FreshPayment FreshPayment = GetFreshPayment(id);
            return View(FreshPayment);
        }

        [HttpPost]
        public JsonResult VehicleLoad(int id)
        {
            var Vehcle = _context.Models.Where(z => z.MakeId == id).ToList();
            return Json(new SelectList( Vehcle,"Id","Name"));
        }

    }
}
