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
             Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            */

            Console.WriteLine("Введите ваш рост в метрах.");
                double growth = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в кг.");
                double weight = double.Parse(Console.ReadLine());  

            double I = weight / (growth * growth);

            Console.WriteLine($"Ваш рост: {growth}");
            Console.WriteLine($"Ваш вес: {weight}");
            Console.WriteLine("Ваш индекс массы тела: " + "{0:N}",I);


        }
    }
}



