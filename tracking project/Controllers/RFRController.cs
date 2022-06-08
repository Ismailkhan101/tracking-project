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
    public class RFRController : Controller
    {

        private readonly VehicleTrackingERPDBContext _context;
        private readonly VehicleTrackingERPDBContext _context2;

        public RFRController(VehicleTrackingERPDBContext context, VehicleTrackingERPDBContext context2)
        {
            _context = context;
            _context2 = context2;
        }
        public IActionResult Index()
        {

            List<RFR> RFRs = _context.RFRs.ToList();
            return View(RFRs);

        }


        public IActionResult RFRCreate()
        {
            List<Customer> Customer = new List<Customer>();
            Customer = _context.Customers.ToList();
            ViewBag.Customer = Customer;

            List<SalePerson> SalePerson1 = new List<SalePerson>();
            SalePerson1 = _context.SalePersons.ToList();
            ViewBag.SalePerson = SalePerson1;

            return View();
        }

       /* public void test()
        {
            Comission a = new Comission();
            a.Commission = 400;
            a.CommissionType = "asdasd";
            a.SalePersonId = 4;
            a.VehicleId = 18;

            _context2.Comissions.Add(a);
            _context2.SaveChanges();
        }*/
        [HttpPost]
        public IActionResult RFRCreate(RFR RFR,double Commission,int Sale)
        {
            /*test();*/

            //Comission com = RFR.Commission;
           

            var vehicle = _context.CustomerVehicles.Where(x => x.VehicalId == RFR.VehicleId).FirstOrDefault();
            if (vehicle.unitId == null)
            {
                ViewBag.unitid = "Vehicke has no device installed";

                List<Customer> Customer = new List<Customer>();
                Customer = _context.Customers.ToList();
                ViewBag.Customer = Customer;

                List<SalePerson> SalePerson = new List<SalePerson>();
                SalePerson = _context.SalePersons.ToList();
                ViewBag.SalePerson = SalePerson;
                return View();
            }
            else
            {
                if (RFR.Request.Equals("transfer", StringComparison.CurrentCultureIgnoreCase))
                {
                    var toVehicle = _context.CustomerVehicles.Where(x => x.VehicalId == RFR.TransferVehicleId).FirstOrDefault();
                    toVehicle.unitId = vehicle.unitId;
                    _context.Entry(toVehicle).State = EntityState.Modified;
                }



                //Comission com = RFR.Commission;
                //com.CommissionType = "Removal for Request";
                //com.VehicleId = RFR.VehicleId;
                //_context2.Comissions.Add(com);
                //_context2.SaveChanges();

                vehicle.unitId = null;
                //  RFR.CommisionId = com.CommisionId;

                _context.Entry(vehicle).State = EntityState.Modified;

                _context.RFRs.Add(RFR);

                _context.SaveChanges();
                Comission com = new Comission();
                com.Commission = Commission;
                com.CommissionType = "Removal for Request";
                com.VehicleId = RFR.VehicleId;
                com.SalePersonId =Convert.ToInt32( RFR.Agent);
                // sale person id
                // comssion value
                _context.Comissions.Add(com);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }


        }
        // it shows the details of customer vehicles
        private RFR GetRFR(int id)
        {
            RFR Rfr = _context.RFRs.FirstOrDefault(u => u.Id == id);
            return Rfr;
        }

        public IActionResult RFRDetails(int id)
        {
            RFR Rfr = GetRFR(id);
            return View(Rfr);
        }

        public IActionResult RFRUpdate(int id)
        {
            RFR RFR = GetRFR(id);
            return View(RFR);
        }

        [HttpPost]
        public IActionResult RFRUpdate(RFR RFR)
        {

            _context.RFRs.Attach(RFR);
            _context.Entry(RFR).State = EntityState.Modified;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult RFRDelete(int id)
        {
            RFR RFR = GetRFR(id);
            return View(RFR);
        }

        [HttpPost]
        public IActionResult RFRDelete(RFR RFR)
        {

            _context.RFRs.Attach(RFR);
            _context.Entry(RFR).State = EntityState.Deleted;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult CustomerLoad()
        {
            ViewBag.Customer = new SelectList(_context.Customers, "CustomerId", "Name");
            return Index();
        }
        [HttpPost]
        public JsonResult VehicleLoad(int id)
        {
            var Vehcle = _context.CustomerVehicles.Where(z => z.CustomerID == id).ToList();
            return this.Json(Vehcle);
        }
    }
}
