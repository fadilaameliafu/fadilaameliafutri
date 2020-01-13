// C# program to illustrate the 
// String.IndexOf(string s1) method 
using System; 
namespace ConsoleApplication4 { 

class Geeks { 

	// Main Method 
	static void Main(string[] args) 
	{ 

		string str = "Jeruk Apel Anggur Pepaya Pisang Kiwi Markisa"; 

		int i = str.IndexOf("Jeruk"); 

		// As this string is present in the 
		// main string then it will obviously 
		// output the value as 17 
		Console.WriteLine("First value Index of 'Jeruk' is " + i); 

		// now the following string is not present 
		// So as per the rules, it will return -1 
		int i1 = str.IndexOf("Pisang"); 

		// As this string is present in 
		// the main string then it will 
		// obviously output the value as -1 
		Console.WriteLine("First value Index of 'Pisang' is " + i1); 
	} 
} 
} 
