using DataLibrary1.DataAccess;
using DataLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace DataLibrary1.BusinessLogic
{
    public class AuctionProcessor
    {
        // Bid on a auction
        public void BidOnAuction(decimal bid, decimal currentPrice, int id, string currentWinner)
        {
            // make a new connection and create sql commands
            var connection = new SqlConnection(SqlDataAccess.GetConnectionString());
            SqlCommand sqlReadCommand = connection.CreateCommand();
            SqlCommand sqlUpdateCommand = connection.CreateCommand();
            SqlCommand sqlReadCommands = connection.CreateCommand();

            connection.Open();
            //read old rowversion
            string sqlRead = @"select RowVer from dbo.Auction where id = @Id";
            string sqlReads = @"select currentPrice from dbo.Auction where id = @Id";
            sqlReadCommand.CommandText = sqlRead;
            sqlReadCommands.CommandText = sqlReads;
            sqlReadCommand.Parameters.AddWithValue("Id", id);
            sqlReadCommands.Parameters.AddWithValue("Id", id);
            decimal oldRowVersions = (decimal)sqlReadCommands.ExecuteScalar();
            object oldRowVersion = sqlReadCommand.ExecuteScalar();
  

            AuctionModel data = new AuctionModel
            {
                CurrentWinner = currentWinner,
                Bid = bid,
                Id = id,
                CurrentPrice = (currentPrice + bid)
            };

            try
            {
                //update only if rowversion is unchanged
                string sqlUpdate = @"update dbo.Auction set currentPrice = @CurrentPrice, currentWinner = @CurrentWinner where id = @Id and RowVer = @RowVers";
                sqlUpdateCommand.CommandText = sqlUpdate;

                sqlUpdateCommand.Parameters.AddWithValue("CurrentPrice", data.CurrentPrice);
                sqlUpdateCommand.Parameters.AddWithValue("CurrentWinner", data.CurrentWinner);
                sqlUpdateCommand.Parameters.AddWithValue("Id", data.Id);
                sqlUpdateCommand.Parameters.AddWithValue("RowVers", oldRowVersion);
                int rowsUpdated = sqlUpdateCommand.ExecuteNonQuery();

                // if the new and old RowVer arent the same there is no updated rows
                if (rowsUpdated == 0)
                {
                    throw new DBConcurrencyException("blop");
                }
                else if (oldRowVersions == data.CurrentPrice)
                {
                    throw new DBConcurrencyException("blopp");
                }

            }
            catch (DBConcurrencyException ex)
            {
                throw new DBConcurrencyException(ex.Message);
            }                
        }
        // Edit auction
        public int EditAuction(int id, decimal bid, int status,
              decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category)
        {
            AuctionModel data = new AuctionModel
            {
                Id = id,
                Bid = bid,
                Status = status,
                CurrentPrice = currentPrice,
                MaxPrice = maxPrice,
                EndDate = endDate,
                Title = title,
                Description = description,
                Category = category
            };
            string sql = @"update dbo.Auction set status = @Status, currentPrice = @CurrentPrice, maxPrice = @MaxPrice, bid = @Bid, endDate = @EndDate, title = @Title, description = @Description, category = @Category WHERE id = @Id;";

            return SqlDataAccess.SaveData(sql, data);
        }
        // Create auction
        public int CreateAuction(decimal bid, int status,
           decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category, string ownerId)
        {

            AuctionModel data = new AuctionModel
            {
                Bid = bid,
                Status = status,
                CurrentPrice = currentPrice,
                MaxPrice = maxPrice,
                EndDate = endDate,
                Title = title,
                Description = description,
                Category = category,
                OwnerId = ownerId
            };
            string sql = @"insert into dbo.Auction (status, currentPrice, maxPrice, bid, endDate, title, description, category, ownerId)
            values (0, @CurrentPrice, @MaxPrice, @Bid, @EndDate, @Title, @Description, @Category, @OwnerId);";

            return SqlDataAccess.SaveData(sql, data);
        }
        // Load auctions
        public List<AuctionModel> LoadAuctions()
        {
            string sql = @"select id, endDate, time, status, currentPrice, maxPrice, bid,  currentWinner, title, description, category, ownerId
                           from dbo.Auction where status = 0;";
            return SqlDataAccess.LoadData<AuctionModel>(sql);
        }
        // Buyout method
        public int BuyoutAuction(int id, decimal maxPrice)
        {
            AuctionModel data = new AuctionModel
            {
                Id = id,
                CurrentPrice = maxPrice,
                MaxPrice = maxPrice
            };
            string sql = @"update dbo.Auction set Status = 1, CurrentPrice = @MaxPrice
            where id = @Id";
            return SqlDataAccess.SaveData(sql, data);
        }
        // Delete auction from desktop
        public int DeleteAuction(int id)
        {
            AuctionModel data = new AuctionModel
            {
                Id = id
            };
            string sql = @"delete dbo.Auction where id = @Id";
            return SqlDataAccess.SaveData(sql, data);
        }
    }
}


