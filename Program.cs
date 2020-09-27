using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массивов
            int [] mas1 = { 1, 3, 7, 3, 5, 7, 5, 9, 102, 2 };
            int [] mas2 = { 4, 3, 2, 3, 4, 7, 3, 4, 4, 5 };
            int [] mas3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //вывод на консоль первого массива
            Console.WriteLine("Первый массив");
            for (int i = 0; i < 10; i++)
            {    
                Console.Write("{0}", mas1[i] + " ");
            }
            //вывод на консоль второго массива
            Console.WriteLine("Второй массив");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}", mas2[i] + " ");
            }
            //вывод на консоль третьего массива (его элементы равны сумме элементов первых двух массивов
            Console.WriteLine("Сгенерированный массив из 1 и 2");
            for (int i = 0; i < 10; i++)
            {
                mas3[i] = mas2[i] + mas1[i];
                Console.Write("{0}", mas3[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
