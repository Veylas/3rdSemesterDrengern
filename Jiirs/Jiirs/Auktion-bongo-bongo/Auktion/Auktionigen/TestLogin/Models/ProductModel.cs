﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestLogin.Models
{
    [Table("ProductModel")]
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Titel")]
        [Required(ErrorMessage = "Du skal intaste en titel")]
        public string Titel { get; set; }

        [Required(ErrorMessage = "Du skal skrive en beskrivelse af dit produkt")]
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }

        [Display(Name = "Katagori")]
        [Required(ErrorMessage = "Du skal vælge en katagori")]
        public string Catagory { get; set; }
    }
}