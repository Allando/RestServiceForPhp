using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestServiceForPhp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRestService.svc or ProductRestService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRestService : IProductRestService
    {
        public List<Product> GetProductList()
        {
            return Products.Instance.ProducktList;
        }

        public Product GetProductById(string id)
        {
            return Products.Instance.ProducktList.Find(p => p.ProductId == int.Parse(id));
        }

        public bool NewProduct(string id, Product item)
        {
            var result = Products.Instance.ProducktList.FirstOrDefault(p => true);
            if (result != null)
            {
                Products.Instance.ProducktList.Add(new Product());
                return true;
            }
            return false;
        }

        public bool UpdatedProduct(string id, Product item)
        {
            var result = Products.Instance.ProducktList.FirstOrDefault(p => p.ProductId == int.Parse(id));
            if (result != null)
            {
                result.Name = item.Name;
                result.CategoryName = item.CategoryName;
                result.Price = item.Price;
                return true;
            }
            return false;
        }

        public bool DeleteProduct(string id)
        {
            var result = Products.Instance.ProducktList.FirstOrDefault(p => p.ProductId == int.Parse(id));
            if (result != null)
            {
                Products.Instance.ProducktList.RemoveAt(result.ProductId);
                return true;
            }
            return false;
        }
    }
}
