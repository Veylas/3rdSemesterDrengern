using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataLibrary.Models
{
    public class AuctionModel
    {
        public int Id { get; set; }
        public DateTime EndDate { get; set; }
        public int Time { get; set; }
        public int Status { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public decimal Bid { get; set; }
        public string CurrentWinner { get; set; }

    }

}
