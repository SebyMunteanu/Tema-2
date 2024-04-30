namespace Tema2Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");

            //modificari
            var fileHandler = new FileHandler();
            var orderSerializer = new OrderSerializer();
            IOrderProcessor orderProcessor = null;
            var hotelReception = new HotelReception(fileHandler, orderSerializer, orderProcessor);
            
            hotelReception.ProcessOrder();

            if (hotelReception.FinalPrice == 0)
            {
                Console.WriteLine("No order was processed.");
            }
            else
            {
                Console.WriteLine($"Final price for you order: {hotelReception.FinalPrice} RON");
            }
        }
    }
}
