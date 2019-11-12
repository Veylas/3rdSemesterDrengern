using Auktionigen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;

namespace Auktionigen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CreateAuction()
        {
            ViewBag.Message = "Udfyld auktionens informationer her her";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAuction(AuktionModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = AuctionProcessor.CreateAuction(model.Title, 
                    model.Tid, 
                    model.CurrentPrice, 
                    model.MaxPrice);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}