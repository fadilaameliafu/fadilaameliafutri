using System; 

class Welcome { 

	// Main Method 
	public static void Main() 
	{ 

		// define string 
		String str = "Welcome To Welcome"; 

		Console.WriteLine("OldString : " + str); 

		Console.WriteLine("NewString: " + str.Replace("Welcome", "---")); 

		Console.WriteLine("\nOldString: " + str); 

		Console.WriteLine("NewString: " + str.Replace("To", "WTW")); 
	} 
} 
