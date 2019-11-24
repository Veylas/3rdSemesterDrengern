using TestLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;


namespace TestLogin.Controllers
{
            
    public class HomeController : Controller
    {
        
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
        public ActionResult BidOnAuction(AuctionModel models)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = AuctionProcessor.BidOnAuction(
                    models.Bid,
                    models.CurrentPrice,
                    models.Id
                    );
                return RedirectToAction("ViewAuction");
            }
            return View();
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

        public ActionResult ViewProduct()
        {
            ViewBag.Message = "Auction list";

            var data = ProductProcessor.LoadProduct();

            List<ProductModel> products = new List<ProductModel>();
            foreach (var row in data)
            {
                products.Add(new ProductModel
                {
                    Titel = row.Titel,
                    Description = row.Description,
                    Catagory = row.Catagory
                });
            }

            return View(products);
        }


        public ActionResult CreateAuction()
        {
            ViewBag.Message = "Udfyld auktionens informationer her her";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAuction(AuctionModel models)
        {
            if(ModelState.IsValid)
                
                {
                int recordsCreated = AuctionProcessor.CreateAuction(models.Bid,
                    models.Status,
                    models.CurrentPrice,
                    models.MaxPrice
                    );
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ViewAuction()
        {
            ViewBag.Message = "Auction list";

            var data = AuctionProcessor.LoadAuctions();

            List<AuctionModel> auctions = new List<AuctionModel>();
            foreach (var row in data)
            {
                auctions.Add(new AuctionModel
                {
                    Id = row.Id,
                    Status = row.Status,
                    CurrentPrice = row.CurrentPrice,
                    MaxPrice = row.MaxPrice,
                    Bid = row.Bid
                });
            }

            return View(auctions);
        }

        public ActionResult GetBlogComment()
        {
            ViewBag.Blog = ViewAuction();
            ViewBag.Comments = ViewProduct();
            return View();
        }

        public ActionResult CreateProduct()
        {
            ViewBag.Message = "Udfyld auktionens informationer her her";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var recordsCreated = ProductProcessor.CreateProduct(model.Titel,
                    model.Description,
                    model.Catagory);
                return RedirectToAction("Index");
            }
            ViewBag.Blog = ViewAuction();
            ViewBag.Comments = ViewProduct();
            return View();
        }
    }
}