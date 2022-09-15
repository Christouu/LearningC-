class Student
{
    public delegate int CalculateHandler(int myArgument1, int myArgument2); //here are 2 arguments like our methods Add and Substract 
    //if we change the number or args here we must change to 3 args in Add and Substract and vise vursa to work properly


    public int Calculate(int arg1, int arg2, CalculateHandler handler)
    {
        var output = handler(arg1, arg2);
        return output;
    }


    public int Add(int arg1, int arg2)
    {
        var output = arg1 + arg2;
        Console.WriteLine("Added: " + output);
        return output;
    }

    public int Substract(int arg1, int arg2)
    {
        var output = arg1 - arg2;
        Console.WriteLine("Subtracted: " + output);
        return output;
    }
}

//  var s = new Student();
//  var calcHandler = new Student.CalculateHandler(s.Add); -> here i point to the method i want to execute
//  s.Calculate(10, 5, calcHandler); - > the calcualte handler i chose was Add. You can change s.Add to s.Substract and see it changes
//  Added: 15

//  Delegates are sometimes  referred to as callback functions!

//  Anonymous mehtods as deleghates
//  var multiply = new Student.CalculateHandler((int arg1, int arg2) => arg1 * arg2);
//  cw(s.Calcualte(10, 5, multiply))

//  Directly cast a delegate when the type is specified
//  s.Calculate(10, 5, s.Add)

//  Multicast delegates
//  var calcualtion = new Student.CalculateHandler(s.Add) + new Student.CalculateHandler(s.Substract);
//  s.Calculate(10, 5, calculation);
//  Added: 15
//  Substract: 5
