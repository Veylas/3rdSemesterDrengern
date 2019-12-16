using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientToService.ModelLayer;
using ClientToService.ServiceReference1;

namespace ClientToService.ServiceLayer
{
    public interface IUseAuctionService
    {
    // Edit       
        void EditAuction(int id, decimal bid,
                              int status,
                              decimal currentPrice,
                              decimal maxPrice,
                              DateTime endDate,
                              string title,
                              string description,
                              string category);
    // Delete
       void DeleteAuction (int id);
        
    }
}
