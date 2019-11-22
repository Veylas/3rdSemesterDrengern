using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class AuctionProcessor
    {
        public static int BidOnAuction(float bid, float currentPrice, int id)
        {
            AuctionModel data = new AuctionModel
            {
                Bid = bid,
                Id = id,
                CurrentPrice = currentPrice * bid
            };
            string sql = @"update dbo.Auction set currentPrice = @CurrentPrice
            where id = @Id";
            return SqlDataAccess.SaveData(sql, data);
        }
            public static int CreateAuction(int status, 
                   float currentPrice, float maxPrice)
        {
            AuctionModel data = new AuctionModel
            {
                Status = status,
                CurrentPrice = currentPrice,
                MaxPrice = maxPrice
            };
            string sql = @"insert into dbo.Auction (status, currentPrice, maxPrice)
            values (@Status, @CurrentPrice, @MaxPrice);";

            return SqlDataAccess.SaveData(sql, data);
        }
         
        public static List<AuctionModel> LoadAuctions()
        {
            string sql = @"select id, endDate, time, status, currentPrice, maxPrice, currentWinner
                           from dbo.Auction;";
            return SqlDataAccess.LoadData<AuctionModel>(sql);
        }
    }
}
