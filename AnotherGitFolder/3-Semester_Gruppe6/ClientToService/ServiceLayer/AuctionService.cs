using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientToService.ServiceReference1;
using ClientM = ClientToService.ModelLayer;

namespace ClientToService.ServiceLayer
{
    public class AuctionService : IUseAuctionService
    {
        // Edit with Proxy
        public void EditAuction(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category)
        {
            Service1Client newProxy = new Service1Client();
            newProxy.EditAuction(id, bid, status, currentPrice, maxPrice, endDate, title, description, category);
            newProxy.Close();
        }
        // Delete with Proxy
        public void DeleteAuction(int id)
        {
            Service1Client newProxy = new Service1Client();
            newProxy.DeleteAuction(id);
            newProxy.Close();
        }
        // Make a List
        public List<ClientM.Auction> LoadAuctions()
        {
            {
                Service1Client myProxy = new Service1Client();
                AuctionModel[] vv = myProxy.LoadAuctions();
                List<ClientM.Auction> foundClientModel = ConvertToClientModel(vv);
                return foundClientModel;
            }

        }
        // Fill List
        public List<ClientM.Auction> ConvertToClientModel(AuctionModel[] WCFModel)
        {
            List<ClientM.Auction> convertFound = new List<ClientM.Auction>();
            ClientM.Auction tempAuction = null;
            foreach (var WCFM in WCFModel)
            {
                tempAuction = new ClientM.Auction();
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
                convertFound.Add(tempAuction);
            }
            return convertFound;
        }
    }
}

