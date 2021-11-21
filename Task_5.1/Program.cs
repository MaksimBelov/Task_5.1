using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[7];
            float aMean = 0;
            Console.WriteLine("Формируем одномерный массив из 7 целых чисел, введеных с клавиатуры:");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(" - введите число N{0} = ", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int i in array)
            {
                aMean += i;
            }
            aMean /= 7;
            Console.WriteLine("Среднее арифметическое введенных числел равно {0:f2}", aMean);
            Console.ReadKey();
        }
    }
}
