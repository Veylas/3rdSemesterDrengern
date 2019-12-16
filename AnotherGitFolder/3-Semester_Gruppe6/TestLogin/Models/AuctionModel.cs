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

        [Display(Name = "Slut dato")]
        [Required(ErrorMessage = "Du skal indtaste en slut dato")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime EndDate { get; set; }


        [Display(Name = "Status")]
        public int Status { get; set; }

        [Display(Name = "Start pris")]
        [Required(ErrorMessage = "Du skal indtaste en start pris")]
        [DataType(DataType.Currency)]
        public decimal CurrentPrice { get; set; }

        [Display(Name = "Køb nu pris")]
        [Required(ErrorMessage = "Du skal indtaste en max pris")]
        [DataType(DataType.Currency)]
        public decimal MaxPrice { get; set; }

        [Required(ErrorMessage = "Du skal indtaste hvor meget prisen skal stige")]
        [DataType(DataType.Currency)]
        [Display(Name = "Byd stigning per bud")]
        public decimal Bid { get; set; }

        [Display(Name = "Titel")]
        [Required(ErrorMessage = "Du skal indtaste en titel")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Du skal skrive en beskrivelse af dit produkt")]
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }

        [Display(Name = "Katagori")]
        [Required(ErrorMessage = "Du skal vælge en katagori")]
        public string Category { get; set; }

        public string CurrentWinner { get; set; }

        [Display(Name = "Oprettet af")]
        public string OwnerId { get; set; }
    }
}