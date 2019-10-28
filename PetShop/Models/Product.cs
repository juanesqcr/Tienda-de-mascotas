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
        public string Characteristic1 { get; set; }
        public string Characteristic2 { get; set; }
        public string Characteristic3 { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }
        public string Photo5 { get; set; }
        public string Photo6 { get; set; }
        public double Price { get; set; }
        public double countCharacteristic { get; set; }
        public double countPhotos { get; set; }
        public string Video { get; set; }
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
             
                //string pathServer = new  System.Web.HttpContext.Current.Server.MapPath("/Content/Products.json");
                var result = System.IO.File.ReadAllText(JsonPath);
                return result;

 
        }

    }
}