class DayOfTheWeek
{

    DayOfWeek dayOfTheWeek = DateTime.Now.DayOfWeek;
    int hourOfDay = DateTime.Now.Hour;

    public void WhatDayItIs(DayOfWeek day, int hour)
    {
        switch (day)
        {
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Friday when hour < 16:
                Console.WriteLine("Work work work...");
                break;
            case DayOfWeek.Friday when hour >= 16:
                Console.WriteLine("The party starts now");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("Chill");
                break;
        }


        WhatDayItIs(dayOfTheWeek, hourOfDay);
    }


}