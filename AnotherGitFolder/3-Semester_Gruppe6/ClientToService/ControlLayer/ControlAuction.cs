using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientToService.ServiceLayer;
using ClientToService.ServiceReference1;
using ClientToService.ModelLayer;

namespace ClientToService.ControlLayer
{
    public class ControlAuction
    {
        // Edit
        public void EditAuction(int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category)
        {
            IUseAuctionService aus = new AuctionService();
            aus.EditAuction(id, bid, status, currentPrice, maxPrice, endDate, title, description, category);
        }
        // Delete
        public void DeleteAuction(int id)
        {
            IUseAuctionService aus = new AuctionService();
            aus.DeleteAuction(id);
        }
        // View auction
        public List<IAuction> ViewAuction()
        {
            AuctionService viewClient = new AuctionService();
            var data = viewClient.LoadAuctions();

            List<IAuction> auctions = new List<IAuction>();
            foreach (var row in data)
            {
                auctions.Add(new Auction
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
                    CurrentWinner = row.CurrentWinner
                });
            }
            return auctions;
        }
    }
}
