class Program
{
    static void Main()
    {

        Pizza pizza1 = new Pizza("white", "tomato", "cream", "mozzarella");

        Console.ReadKey();
    }
}

class Pizza
{
    string bread;
    string sauce;
    string cheese;
    string topping;


    public Pizza(string bread, string sauce)
    {
        this.bread = bread;
        this.sauce = sauce;

    }

    public Pizza(string bread, string cheese, string topping)
    {
        this.bread = bread;
        this.cheese = cheese;
        this.topping = topping;
    }

    public Pizza(string bread, string sauce, string cheese, string topping)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        this.topping = topping;
    }
}