using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        

        static void Main()
        {
            /* 
             1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            В результате вся информация выводится в одну строчку:

            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $. +

            */

            Console.WriteLine("Введите ваше Имя.");
                string name = Console.ReadLine();
            Console.WriteLine("Введите вашу Фамилию.");
                string secondname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст.");
                string age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост.");
                string growth = Console.ReadLine();
            Console.WriteLine("Введите ваш вес.");
                string weight = Console.ReadLine();

            Console.WriteLine($"Уважаемый {secondname} {name}. " + "Вам " + "{0:N}",age + "лет." + $"Ваш рост {growth}, а вес {weight}");


        }
    }
}



