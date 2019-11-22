using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestLogin.Models
{
    public class AuctionModel
    {
        public int Id { get; set; }
        public DateTime EndDate {get; set;}

        public int Time { get; set; }

        public int Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:#,##0.00#}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency)]
        public float CurrentPrice { get; set; }

        [Display(Name = "Max Pris")]
        [Required(ErrorMessage = "Du skal intaste en max pris")]
        public float MaxPrice { get; set; }

        public float Bid = 1.100f;
      

        public string CurrentWinner { get; set; }

    }
}