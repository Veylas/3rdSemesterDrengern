using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestLogin.Models
{
    public class ViewModel
    { 
        public IEnumerable<AuctionModel> ListModel1;
        public IEnumerable<ProductModel> ListModel2;
    }
}