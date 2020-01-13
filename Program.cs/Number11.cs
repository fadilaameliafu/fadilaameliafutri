using System;

class Sample
{
	static void Main(string[] args)
	{
		int SUM	= 0;
		int X	= 0;
		int Y	= 0;
		int Z	= 0;
		int A	= 0;

		X = Convert.ToInt32(args[0]);
		Y = Convert.ToInt32(args[1]);
		Z = Convert.ToInt32(args[0]);
		A = Convert.ToInt32(args[1]);

		SUM = X + Y + Z + A;

		Console.WriteLine("Sum is: "+SUM);
		
	}
}