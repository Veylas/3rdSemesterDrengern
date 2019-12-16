using TestLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLogin.ServiceLayer;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Security.Claims;
using System.ServiceModel;

namespace TestLogin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Authorize]
        // Bid
        public ActionResult BidOnAuction(int Id = 1, decimal CurrentPrice=1, decimal Bid=1)
        {
            {
                ViewBag.Message = "Udfyld auktionens informationer her her";
                ViewData["Bid"] = Bid;
                ViewData["Id"] = Id;
                ViewData["CurrentPrice"] = CurrentPrice;


            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // Bid
        public ActionResult BidOnAuction(AuctionModel models)
        {
           {
                ClientService CS = new ClientService();
                try
                {
                    CS.BidOnAuction(
                             models.Bid,
                             models.CurrentPrice,
                             models.Id,
                             models.CurrentWinner = HttpContext.User.Identity.Name
                             );

                } catch (Exception)
                {
                    return View("Error");
                }
            }
  
            return RedirectToAction("ViewAuction");
          
        }


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

        [Authorize]
        // Create auction
        public ActionResult CreateAuction()
        {
            
            ViewBag.Message = "Udfyld auktionens informationer her her";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Create auction
        public ActionResult CreateAuction(AuctionModel models)
        {
            ClientService clientService = new ClientService();
           if(ModelState.IsValid)
                
                {
                clientService.CreateAuction(
                    models.Bid,
                    models.Status,
                    models.CurrentPrice,
                    models.MaxPrice,
                    models.EndDate,
                    models.Title,
                    models.Description,
                    models.Category,
                    models.OwnerId = HttpContext.User.Identity.Name
                    );
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize]
        // Show a list with auctions
        public ActionResult ViewAuction()
        {
            ViewBag.Message = "Auction list";
            ClientService viewClient = new ClientService();
            var data = viewClient.LoadAuctions();
            List<AuctionModel> auctions = new List<AuctionModel>();
            foreach (var row in data)
            {
                auctions.Add(new AuctionModel
                {
                    Id = row.Id,
                    Status = row.Status,
                    CurrentPrice = row.CurrentPrice,
                    MaxPrice = row.MaxPrice,
                    Bid = row.Bid,
                    EndDate = row.EndDate,
                    Title = row.Title,
                    Description = row.Description,
                    Category = row.Category,
                    CurrentWinner = row.CurrentWinner,
                    OwnerId = row.OwnerId
                });
            }
            return View(auctions);
        }
        [Authorize]
        // Buyout
        public ActionResult BuyoutAuction(int Id = 1, decimal MaxPrice = 1)
        {
            ViewBag.Message = "Udfyld auktionens informationer her her";

            ViewData["Id"] = Id;
            ViewData["MaxPrice"] = MaxPrice;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Buyout
        public ActionResult BuyoutAuction(AuctionModel model)
        {          
            ClientService buyoutClient = new ClientService();
            {
                buyoutClient.BuyoutAuction(
                    model.Id,
                    model.MaxPrice

                    );
                return RedirectToAction("ViewAuction");
            }               
        }
    }
}