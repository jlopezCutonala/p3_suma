using System;

namespace p3_suma
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Dame el primer número:");
			int numero1= int.Parse(Console.ReadLine());
			Console.WriteLine("Dame el segundo número:");
			int numero2= int.Parse(Console.ReadLine());

			int resultado = numero1 + numero2;
			Console.WriteLine("El resultado es " + resultado);
		}
	}
}
