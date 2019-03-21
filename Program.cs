using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            char symbol;
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Введите символ: ");
                symbol = char.Parse(Console.ReadLine());
                if (symbol == ' ')
                {
                    counter++;
                }
                if (symbol == '.')
                {
                    break;
                }
            }
            Console.WriteLine("Количество пробелов:" + counter);
           

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            int ticket, number1, number2, number3, number4, number5, number6;
            Console.WriteLine("Введите шестизначное число: ");
            ticket = int.Parse(Console.ReadLine());
            number1 = ticket / 100000;
            number2 = (ticket / 10000) % 10;
            number3 = (ticket / 1000) % 10;
            number4 = (ticket % 1000) / 100;
            number5 = (ticket % 100) / 10;
            number6 = ticket % 10;
            if ((number1 + number2 + number3) == (number4 + number5 + number6))
            {
                Console.WriteLine("Ваш билет удачный!");
            }
            else
            {
                Console.WriteLine("Ваш билет обычный");
            }
         

            Console.WriteLine();
            Console.WriteLine("Задание 4");

            int numberA, numberB;
            Console.WriteLine("Введите А и В: ");
            numberA = int.Parse(Console.ReadLine());
            numberB = int.Parse(Console.ReadLine());
            for (int i = numberA; i < numberB; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i );
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
