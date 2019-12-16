using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientM = TestLogin.Models;
using TestLogin.ServiceReference1;

namespace TestLogin.ServiceLayer
{
    public class ClientService
    {
        // Create Proxy and call CreateAuction
        public void CreateAuction(decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category, string ownerId)
        {
            Service1Client newProxy = new Service1Client();
            newProxy.CreateAuction(bid, status, currentPrice, maxPrice, endDate, title, description, category, ownerId);
            newProxy.Close();
        }

        // Bid with Proxy
        public void BidOnAuction(decimal bid, decimal currentPrice, int id, string currentWinner)
        {
            try
            {
                Service1Client newBidClient = new Service1Client();
                newBidClient.BidOnAuction(bid, currentPrice, id, currentWinner);
                newBidClient.Close();
            } 
             catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Create a List and Proxy
        public List<ClientM.AuctionModel> LoadAuctions()
        {
            {
                Service1Client myProxy = new Service1Client();
                AuctionModel[] vv = myProxy.LoadAuctions();
                List<ClientM.AuctionModel> foundClientModel = ConvertToClientModel(vv);
                return foundClientModel;
            }

        }
        // Fill the new List with auctionModels
        public List<ClientM.AuctionModel> ConvertToClientModel(AuctionModel[] WCFModel)
        {
            List<ClientM.AuctionModel> convertFound = new List<ClientM.AuctionModel>();
            ClientM.AuctionModel tempAuction = null;
            foreach (var WCFM in WCFModel)
            {
                tempAuction = new ClientM.AuctionModel();
                tempAuction.Id = WCFM.Id;
                tempAuction.MaxPrice = WCFM.MaxPrice;
                tempAuction.CurrentPrice = WCFM.CurrentPrice;
                tempAuction.EndDate = WCFM.EndDate;
                tempAuction.Bid = WCFM.Bid;
                tempAuction.Title = WCFM.Title;
                tempAuction.Description = WCFM.Description;
                tempAuction.Category = WCFM.Category;
               tempAuction.CurrentWinner = WCFM.CurrentWinner;
                tempAuction.Status = WCFM.Status;
                tempAuction.OwnerId = WCFM.OwnerId;
                // tempAuction.Time = WCFM.Time;


                convertFound.Add(tempAuction);
            }
            return convertFound;
        }
        // Proxy Buyout
        public void BuyoutAuction(int id, decimal maxPrice)
        {
            Service1Client newBuyOutClient = new Service1Client();
            newBuyOutClient.BuyoutAuction(id, maxPrice);
            newBuyOutClient.Close();
        }

    }
}
