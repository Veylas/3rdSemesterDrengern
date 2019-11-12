using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auktionigen.Models
{
    public class Produkt
    {

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Du skal intaste en titel")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Du skal indtaste en beskrivelse af din vare")]
        [Display(Name = "Beskrivelse")]
        public string Beskrivelse { get; set; }

        [Display(Name = "Katagori")]
        [Required(ErrorMessage = "Du skal vælge en katagori")]
        public string CurrentPrice { get; set; }

    }
}