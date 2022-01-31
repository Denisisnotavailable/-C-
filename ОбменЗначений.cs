using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	public class EmptyClass
	{
		static void Main()
		{
			/* 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.

               а) с использованием третьей переменной;
               б) *без использования третьей переменной.
			*/

			//а и б с фиксированным значением.
			int a = 1;
			int b = 2;

			Console.WriteLine($"a = {a}, b = {b}");
			Console.WriteLine(" ");

			//обмен через третью переменную.
			int c = a; 
			a = b; 
			b = c;

			Console.WriteLine($"a = {a}, b = {b}");
			Console.WriteLine(" ");

//Хитрость. При вводе любых значений переменных они всегда будут поменяны местами
			Console.WriteLine("Введите z");
			int z = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите x");
			int x = int.Parse(Console.ReadLine());

			Console.WriteLine($"z = {x}, x = {z}");
			Console.WriteLine(" ");

			int e = 1;
			int f = 2;

			Console.WriteLine($"e = {e}, f = {f}");

			e = e - f; //
			f = e + f; //f = e - f + f = e
			e = f - e; //e = e + f - e = f

		    Console.WriteLine($"e = {e}, f = {f}");



		}
	}
}

