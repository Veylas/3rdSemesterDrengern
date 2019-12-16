using DataLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataLibrary1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<AuctionModel> LoadAuctions();

        [OperationContract]
        void CreateAuction(decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category, string ownerId);

        [OperationContract]
        string GetData(int value);

        [OperationContract]

        void BidOnAuction(decimal bid, decimal currentPrice, int id, string currentWinner);

        [OperationContract]
        void BuyoutAuction(int id, decimal maxPrice);

        
        [OperationContract]
        void DeleteAuction(int Id);

        [OperationContract]
        void EditAuction (int id, decimal bid, int status, decimal currentPrice, decimal maxPrice, DateTime endDate, string title, string description, string category);
    }
}
