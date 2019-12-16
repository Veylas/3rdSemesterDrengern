using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataLibrary1.BusinessLogic;
using DataLibrary1.Models;

namespace DataLibrary1
{
    public class Service1 : IService1
    {
        // Bid
        public void BidOnAuction(decimal bid, decimal currentPrice, int id, string currentWinner)
        {
            {
                AuctionProcessor APBid = new AuctionProcessor();
                APBid.BidOnAuction(bid, currentPrice, id, currentWinner);
            }
        }
        // Buyout
        public void BuyoutAuction(int id, decimal maxPrice)
        {
            AuctionProcessor APBuyout = new AuctionProcessor();
            APBuyout.BuyoutAuction(id, maxPrice);
        }
        // Create
        public void CreateAuction(decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category, string ownerId)
        {
            AuctionProcessor AP = new AuctionProcessor();
            AP.CreateAuction(bid, status, currentPrice, maxPrice, endDate, title, description, category, ownerId);
        }
        // Edit
        public void EditAuction(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category)
        {
            AuctionProcessor AP = new AuctionProcessor();
            AP.EditAuction(id, bid, status, currentPrice, maxPrice, endDate, title, description, category);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        // Load
        public List<AuctionModel> LoadAuctions()
        {
            AuctionProcessor AP = new AuctionProcessor();
            return AP.LoadAuctions();
        }

        // Delete
        public void DeleteAuction(int id)
        {
            AuctionProcessor ctrlAuction = new AuctionProcessor();
            ctrlAuction.DeleteAuction(id);
        }
    }
}
