namespace Lab4Web.Services.Linq
{
    public interface ILinqService
    {
        List<Product.Product> GetProductsByCategory(string category);
        List<string> GetProductNames();
        int GetProductCount();
        List<Product.Product> GetProductsByPrice(decimal price);
        List<Product.Product> GetProductsWithStock();
        Dictionary<string, List<Product.Product>> GroupProductsByCategory();
    }

}
