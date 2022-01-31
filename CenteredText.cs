using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

         /*
			а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
         */

namespace CenteredText
{
	class CenteredText
	{ 

		private static void Print(string text)                   //Создадим метод(функцию) для вывода любого текста по центру экрана.
		{
			var width = Console.WindowWidth;                    //Присвоили размеры консоли переменной.
			var center = width / 2 + text.Length / 2;          //Центрирование по горизонтали(Ширина окна консоли пополам = центр окна,
                                                              //длина текста пополам = центр текста).
			Console.WriteLine("{0," + center + "}", text);   //Выводим текст, где 0 - первый элемент(текст),
                                                            //а переменная center укажет на расположение текста по правому краю символьного поля(тк занк положительный), по центру.
		}

        static void Main()

		{
			
			Print("Здравствуй! Давай знакомиться!");
			
            Print("Как тебя зовут?.");
			string name = Console.ReadLine();

			Print("Какова твоя фамилия?");
			string secondname = Console.ReadLine();

			Print("А из какого ты города?");
			string city = Console.ReadLine();


			Print($"Давай проверим, всё ли я верно понял: Тебя зовут { name } { secondname }, " +
                  $" ты из города { city }, верно?");  //обращаемся к методу.
			Print($"Верно/не верно?");

			string vernoneverno = Console.ReadLine();

			if (vernoneverno == "Верно")
            {
				Print($"Спасибо, рад знакомству!");
            }
			else if (vernoneverno == "верно")

            {
				Print($"Спасибо, рад знакомству!");
			}
			else

            {
				Print($"Теперь ты { name } { secondname } из города { city }. Начинай привыкать. ");
            }

		}

	}
	
}

