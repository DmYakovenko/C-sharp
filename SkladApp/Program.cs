
namespace SkladApp
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Product t1 = new Product("Товар1", 5, 100);
            Console.WriteLine(t1.GetInfo());

            t1.Sell(20);
            Console.WriteLine(t1.GetInfo());

            t1.Restock(50);
            Console.WriteLine(t1.GetInfo());

            t1.Price = 7;
            Console.WriteLine(t1.GetInfo());

            Product t3 = new Product();
            Console.WriteLine(t3.GetInfo());

        }
    }
}
