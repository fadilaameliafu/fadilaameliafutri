using System;
					
public class Program
{
	public static void Main()
	{
		int nilai = 73;
		
		if (nilai < 59) {
		
			Console.WriteLine("Nilai Kamu E" );
		}
		else if  (nilai < 60) {
		
			Console.WriteLine("Nilai kamu D");
		}
		else if  (nilai < 70) {
		
			Console.WriteLine("Nilai kamu C");
		}
		else if  (nilai < 80) {
		
			Console.WriteLine("Nilai kamu B");
		}
		else {
			Console.WriteLine("Nilai kamu A");
		}
		
	}
}