// C# program sort an array in decreasing order 
// using Array.Sort() and Array.Reverse() Method 
using System; 

class GFG { 

	// Main Method 
	public static void Main() 
	{ 

		// declaring and initializing the array 
		int[] arr = new int[] {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45}; 

		// Sort array in ascending order. 
		Array.Sort(arr); 

		// reverse array 
		Array.Reverse(arr); 

		// print all element of array 
		foreach(int value in arr) 
		{ 
			Console.Write(value + " "); 
		} 
	} 
} 
