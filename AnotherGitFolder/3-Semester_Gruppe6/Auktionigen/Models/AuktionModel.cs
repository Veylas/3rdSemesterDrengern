using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auktionigen.Models
{
    public class AuktionModel
    {
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Du skal intaste en titel")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Du skal intaste et tal mellem 5 og 150")]
        [Range(5,150, ErrorMessage = "Du skal intaste et tal mellem 5 og 150")]
        [Display(Name = "Antal timer")]
        public int Tid { get; set; }


        [Display(Name = "Start Pris")]
        [Required(ErrorMessage = "Du skal intaste en start pris")]
        public float CurrentPrice { get; set; }

        [Display(Name = "Max Pris")]
        [Required(ErrorMessage = "Du skal intaste en max pris")]
        public float MaxPrice { get; set; }

    }
}