using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestLogin.Models
{
    [Table("AuctionModel")]
    public class AuctionModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Slut dato")]
        public DateTime EndDate { get; set; }

        public int Time { get; set; }

        [Display(Name = "Status")]
        public int Status { get; set; }

        [Display(Name = "Pris")]
        //[DisplayFormat(DataFormatString = "{0:#,##0.0#}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Currency)]

        [DataType(DataType.Currency)]
        public decimal CurrentPrice { get; set; }

        [Display(Name = "Køb nu pris")]
        [Required(ErrorMessage = "Du skal intaste en max pris")]
        [DataType(DataType.Currency)]
        public decimal MaxPrice { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Byd beløb")]
        public decimal Bid { get; set; }

        [Display(Name = "Nuværende vinder")]
        public string CurrentWinner { get; set; }

        [ForeignKey("ProductId")]
        public virtual int ProductId { get; set; }
        public virtual ProductModel Product{ get; set; }
    }
}