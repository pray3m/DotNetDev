using System;

// define an enum 
enum Weekdays
{
    sunday,
    monday,
    tuesday,
}
class Enums
{
    public static void Main()
    {
        // assign sunday to meetingDay
        Weekdays meetingDay = Weekdays.sunday;

        Console.WriteLine($" {meetingDay} is in position {(int)meetingDay}");
    }
}