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
        public IActionResult Delete(int id)
        {
            Company company = _context.Company.Where(x=>x.CompanyId == id).FirstOrDefault();
            return View(company);
        }

        [HttpPost]
        public IActionResult Delete(Company company)
        {
            try
            {
                _context.Company.Attach(company);
                _context.Entry(company).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("index");
        }
    }
}
