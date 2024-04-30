namespace Lab4Web.Services.Linq.Product
{
    public class Depozit
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Category = "Electronice", Price = 1500, StockQuantity = 10 },
        new Product { Id = 2, Name = "Telefon", Category = "Electronice", Price = 800, StockQuantity = 20 },
        
    };

        public static List<Product> Products => products;
    }
}
