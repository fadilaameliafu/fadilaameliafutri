using System; 

class GFG 
{ 

	class Pair 
	{ 
		public int min; 
		public int max; 
	} 

	static Pair getMinMax(int []arr, int n) 
	{ 
		Pair minmax = new Pair(); 
		int i; 


		if (n == 1) 
		{ 
			minmax.max = arr[0]; 
			minmax.min = arr[0]; 
			return minmax; 
		} 


		if (arr[0] > arr[1]) 
		{ 
			minmax.max = arr[0]; 
			minmax.min = arr[1]; 
		} 
		else
		{ 
			minmax.max = arr[1]; 
			minmax.min = arr[0]; 
		} 

		for (i = 2; i < n; i++) 
		{ 
			if (arr[i] > minmax.max) 
			{ 
				minmax.max = arr[i]; 
			} 
			else if (arr[i] < minmax.min) 
			{ 
				minmax.min = arr[i]; 
			} 
		} 
		return minmax; 
	} 

	// Driver Code 
	public static void Main(String []args) 
	{ 
		int []arr = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54}; 
		int arr_size = 6; 
		Pair minmax = getMinMax(arr, arr_size); 
		Console.Write("Minimum element is {0}", 
								minmax.min); 
		Console.Write("\nMaximum element is {0}", 
									minmax.max); 
	} 
} 

