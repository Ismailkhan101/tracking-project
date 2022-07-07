using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tracking_project.Models;

namespace tracking_project.Controllers
{
    public class ModelController : Controller
    {
        private readonly VehicleTrackingERPDBContext _context;

        public ModelController(VehicleTrackingERPDBContext context)
        {
            _context = context;
        }





        public IActionResult Index()
        {

            List<Model> Model = _context.Models.ToList();
            return View(Model);

        }


        public IActionResult ModelCreate()
        {
            ViewBag.Make = _context.Makes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult ModelCreate(Model Model)
        {

            if ((Model.Name != null))
            {
                _context.Models.Add(Model);
                _context.SaveChanges();
            }
            

           

            return RedirectToAction("Index");
        }

        private Model GetModel(int id)
         {
            Model Models = _context.Models.FirstOrDefault(u => u.Id == id);
             return Models;
         }

        public IActionResult ModelUpdate(int id)
        {
            Model Model = GetModel(id);
           return View(Model);
      }

       [HttpPost]
        public IActionResult ModelUpdate(Model Model)
        {
          
               _context.Models.Attach(Model);
               _context.Entry(Model).State = EntityState.Modified;
              _context.SaveChanges();
          
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            Model Model = _context.Models.Where(x => x.Id == id).FirstOrDefault();
            return View(Model);
        }

        [HttpPost]
        public IActionResult Delete(Model Model)
        {
           
                _context.Models.Attach(Model);
                _context.Entry(Model).State = EntityState.Deleted;
                _context.SaveChanges();
           
            return RedirectToAction("index");
        }
    }
}
