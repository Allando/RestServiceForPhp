using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestServiceForPhp
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public int Price { get; set; }
    }

    public partial class Products
    {
        private static readonly Products _instance = new Products();

        private Products() { }

        public static Products Instance
        {
            get { return _instance; }
        }

        public List<Product> ProducktList
        {
            get { return productsList; }
        }

        private List<Product> productsList = new List<Product>()
        {
            new Product() {ProductId = 1, CategoryName = "M", Name = "A", Price = 10},
            new Product() {ProductId = 2, CategoryName = "N", Name = "B", Price = 20},
            new Product() {ProductId = 3, CategoryName = "O", Name = "C", Price = 30},
            new Product() {ProductId = 4, CategoryName = "P", Name = "D", Price = 40},
            new Product() {ProductId = 5, CategoryName = "Q", Name = "E", Price = 50},
        };
    }
}