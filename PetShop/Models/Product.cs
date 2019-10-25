using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionShort { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public int IdCategory { get; set; }

        public string JsonPath { get; set; }
        public List<Product> getAllProducts()
        {
            var jsonProductList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(this.GetJsonProducts());

            return jsonProductList;
        }

        public Product GetProductById(int id)
        {
            var productList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(this.GetJsonProducts());
            var Result = productList.FirstOrDefault(a => a.Id == id);
            return Result;
        }

        private string GetJsonProducts()
        {
            try
            {
                //string pathServer = new  System.Web.HttpContext.Current.Server.MapPath("/Content/Products.json");
                var result = System.IO.File.ReadAllText(JsonPath);
                return result;


            }
            catch (Exception ex)
            {

                return string.Empty;
            }
        }

    }
}