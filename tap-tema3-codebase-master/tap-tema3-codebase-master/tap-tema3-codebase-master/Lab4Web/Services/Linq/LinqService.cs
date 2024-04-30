using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab4Web.Services.Linq
{
    public class LinqService : ILinqService
    {
        public List<Product.Product> GetProductsByCategory(string category)
        {
            
            var query = from product in Product.Depozit.Products
                        where product.Category == category
                        select product;
            return query.ToList();
        }

        public List<string> GetProductNames()
        {
           
            var query = Product.Depozit.Products.Select(product => product.Name);
            return query.ToList();
        }

        public int GetProductCount()
        {
           
            var query = (from product in Product.Depozit.Products select product).Count();
            return query;
        }

        public List<Product.Product> GetProductsByPrice(decimal price)
        {
            
            var query = Product.Depozit.Products.Where(product => product.Price <= price).ToList();
            return query;
        }

        public List<Product.Product> GetProductsWithStock()
        {
          
            var query = from product in Product.Depozit.Products
                        join stock in Product.Registru.Stocks on product.Id equals stock.ProductId
                        where stock.Quantity > 0
                        select product;
            return query.ToList();
        }

        public Dictionary<string, List<Product.Product>> GroupProductsByCategory()
        {
           
            var query = Product.Depozit.Products.GroupBy(product => product.Category)
                                                 .ToDictionary(group => group.Key, group => group.ToList());
            return query;
        }
    }
}
