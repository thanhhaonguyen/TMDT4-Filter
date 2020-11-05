using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT4.Models;

namespace TMDT4.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        // Company
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        // SCREEN SOLUTION
        public ActionResult getScreenResolution()
        {
            var ListScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListScreenResolution);
        }
        // TYPE NAME
        public ActionResult getTypeName()
        {
            var ListTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeName);
        }
        // INCHES
        public ActionResult getInches()
        {
            var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInches);
        }
        // CPU
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        // SPEED
        public ActionResult getSpeed()
        {
            var ListSpeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key);
            return PartialView(ListSpeed);
        }
        // MEMORY
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        // RAM
        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
            return PartialView(ListRam);
        }
        // GPU
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        // OS
        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOS);
        }
        // Weight
        public ActionResult getWeight()
        {
            var ListWeight = db.laptops.GroupBy(l => l.Weight).Select(l => l.Key);
            return PartialView(ListWeight);
        }
        // Price low #case12
        public ActionResult getPriceLow()
        {
            var priceLow = 0;
            return PartialView(priceLow);
        }
        // Price height #case13
        public ActionResult getPriceHight()
        {
            var priceHight = 0;
            return PartialView(priceHight);
        }
    }
}