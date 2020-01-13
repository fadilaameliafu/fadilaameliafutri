using System;
class Example30
{
    public static void Main() 
    {
     //establish DateTimes
DateTime start = new DateTime(1997, 8, 8);
DateTime end = new DateTime(2020, 1, 13);

TimeSpan difference = end - start; //create TimeSpan object

Console.WriteLine("Difference in days: " + difference.Days); //Extract days, write to Console.
    }
}