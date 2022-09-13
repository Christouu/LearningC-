class Program
{
    static void Main(string[] args)
    {
        double total = CheckOut(3.99, 1.23, 2.5);


        Console.WriteLine(total);
        Console.ReadKey();
    }

    static double CheckOut(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)

        {
            total += price;
        };

        return total;
    }
}