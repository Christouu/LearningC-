var seconds = DateTime.Now.Second;

Console.WriteLine("Current seconds: " + seconds);

/*
if (seconds % 2 == 0)
{
    Console.WriteLine("Seconds are even");
}
else if (seconds % 3 == 0)
{
    Console.WriteLine("Seconds are a multiple of number 3");
}
else
{
    Console.WriteLine("Seconds are neither even nor a multiple of 3");
}
*/



// OR | , AND & 
if (seconds % 2 == 0 & seconds % 3 == 0)
{
    Console.WriteLine("Seconds are even AND a multiple of 3");
}
else if (seconds % 2 == 0)
{
    Console.WriteLine("Seconds are even");
}
else if (seconds % 3 == 0)
{
    Console.WriteLine("Seconds are not even");
}