namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.Go();

            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            bike.Go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.Go();

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
    }

    class Bike : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}