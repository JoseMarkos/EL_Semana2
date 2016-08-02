using System;
					
public class Program
{
	public static void Main()
	{
    int num, ancho, num_total;
    string[] cascada = new string[1];
		
		Console.WriteLine("Ingrese el numero: ");
		num = Int32.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el ancho: ");
		ancho = Int32.Parse(Console.ReadLine());
    num_total = ancho;
    
    Array.Resize(ref cascada, ancho);

		for (int i=0; i < ancho; i++)
		{
      letters[i] = ancho;
      num_total = num_total - 1;
      ancho = ancho + num_total;
    
			Console.WriteLine(letters[i]);

      if (i == Array.FindAll(cascada, s => s.Equals(i)))
      {
        Console.WriteLine("");
      }
		}
    
    /*
    foreach(string item in yourArray)
    {
          Console.WriteLine(item.ToString());
    }
    */
  }
}	
