namespace Lab4Web.Services.Linq.Product
{
    public static class Registru
    {
        private static List<Stock> stocks = new List<Stock>
        {
            new Stock { ProductId = 1, Quantity = 10 },
            new Stock { ProductId = 2, Quantity = 20 },
            
        };

        public static List<Stock> Stocks => stocks;
    }
}
