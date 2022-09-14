namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

           Vehicle vehicle = new Vehicle();

            Console.ReadKey();
        }
    }

     class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Bike : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}