class Student
{
    //This public constructor is created by default by the compiler,
    //and does not need explicitly be added if no action methods take place during constructing
    //  public Student()
    //  {
    //      by default prop
    //      IsEnrolled = true;
    //  }

    //overload the consstructor to take an param
    //  public Student(string firstName, string lastName, int age)
    //  {
    //by default prop
    //   this.Age = age;
    //   this.FirstName = firstName;
    //   this.LastName = lastName;
    //   IsEnrolled = true;
    //  }

    public Student()
    {

        IsEnrolled = false;

    }


    public Student(string firstName) : this() //when we use this constructor to create a student
                                              //after it's done executing this() will call the constructor with IsEnrolled = false;
                                              //Chaining Constructors
    {

        this.FirstName = firstName;

    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsEnrolled { get; set; }

}

//Create a new Student object and assign it
//var s = new Student();
//s.FirstName = "Ivan";
//s.LastName = "Petkov";
//s.Age = 30;

//var s2 = new Student() {
//  FirstName = "Ivan",
//  LastName = "Petkov",
//  Age = 30,
//};

//var s3 = new Student(30);

//var s4 = new Student("Ivan", "Petkov" ,30);

