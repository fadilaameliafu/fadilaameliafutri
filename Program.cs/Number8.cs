using System; 
  
class GFG { 
  
    // Main Method 
    public static void Main() 
    { 
  
        // Checing the leap year between 2000 to 2019 
        for (int y = 2000; y <= 2019; y++)  
        { 
  
            // using method 
            if (DateTime.IsLeapYear(y))  
            { 
                Console.WriteLine("{0} is a Leap Year.", y); 
            } 
  
            else 
            { 
                Console.WriteLine("{0} is not a Leap Year.", y); 
            } 
        } 
    } 
}