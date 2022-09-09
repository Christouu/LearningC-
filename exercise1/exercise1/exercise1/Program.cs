
namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many rows?:");
            int rows = Convert.ToInt32(Console.ReadLine()); //ReadLine always takes a string
            Console.WriteLine("How many columns?:");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What symbol?:");
            string symbol = Console.ReadLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(symbol);
            }

            Console.ReadKey();
        }
    }
}
