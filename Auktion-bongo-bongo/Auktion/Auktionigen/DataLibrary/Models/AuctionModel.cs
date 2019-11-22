using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class AuctionModel
    {
        public int Id { get; set; }
        public string EndDate { get; set; }
        public int Time { get; set; }
        public int Status { get; set; }
        public float CurrentPrice { get; set; }
        public float MaxPrice { get; set; }

        public float Bid = 1.100f;
        public string CurrentWinner { get; set; }
    }

}
