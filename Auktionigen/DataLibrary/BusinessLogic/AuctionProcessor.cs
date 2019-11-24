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
        public static int CreateAuction(string titel, int time, 
                   float currentPrice, float maxPrice)
        {
            AuctionModel data = new AuctionModel
            {
                Titel = titel,
                Time = time,
                CurrentPrice = currentPrice,
                MaxPrice = maxPrice,
            };
            string sql = @"insert into dbo.testAuction (titel, time, currentPrice, maxPrice)
            values (@titel, @time, @currentPrice, @maxPrice);";

            return SqlDataAccess.SaveData(sql, data);
        }
         
        public static List<AuctionModel> LoadAuctions()
        {
            string sql = @"select title, time, currentPrice, maxPrice
                           from dbo.testAuction;";
            return SqlDataAccess.LoadData<AuctionModel>(sql);
        }
    }
}
