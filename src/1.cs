using System;
					
public class Program
{
	public static void Main()
	{
		string[] letters = new string[3];
		
		Console.WriteLine("Ingrese letra1: ");
		letters[0] = Console.ReadLine();
		
		Console.WriteLine("Ingrese letra2: ");
		letters[1] = Console.ReadLine();
		
		Console.WriteLine("Ingrese letra3: ");
		letters[2] = Console.ReadLine();
		
		Array.Reverse(letters);
    Console.WriteLine("");
    	
		for (int i=0; i < letters.Length; i++)
		{
			Console.WriteLine(letters[i]);
		}
	}
