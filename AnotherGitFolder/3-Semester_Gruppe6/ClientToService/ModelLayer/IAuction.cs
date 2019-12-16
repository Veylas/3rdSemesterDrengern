using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientToService.ModelLayer
{
    public interface IAuction
    {
        int Id { get; set; }
        DateTime EndDate { get; set; }
        int Time { get; set; }
        int Status { get; set; }
        decimal CurrentPrice { get; set; }
        decimal MaxPrice { get; set; }

        decimal Bid { get; set; }
        string CurrentWinner { get; set; }

        string Title { get; set; }
        string Description { get; set; }
        string Category { get; set; }
     }
}
