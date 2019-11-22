using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
   public static class ProductProcessor
    {
        public static float CreateProduct(string titel, string description,
                   string catagory)
        {
            ProductModel data = new ProductModel
            {
                Titel = titel,
                Description = description,
                Catagory = catagory
            };
            string sql = @"insert into dbo.Product (titel, description, catagory)
            values (@Titel, @Description, @Catagory);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ProductModel> LoadProduct()
        {
            string sql = @"select titel, description, catagory
                           from dbo.Product;";
            return SqlDataAccess.LoadData<ProductModel>(sql);
        }
    }
}
