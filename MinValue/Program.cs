using System.ComponentModel.Design;
using System.Net.Security;

namespace MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nMinValue = int.MaxValue;
            Console.WriteLine("Введите из скольки чисел определить минимальное значение:");
            int nCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < nCount; i++)
            {
                if (i == 0) 
                {
                    Console.WriteLine("Начинайте вводить цифры:");
                        }
                else { Console.WriteLine("Следующая цифра:"); }
                int nUserValue = int.Parse(Console.ReadLine());
                if (nMinValue > nUserValue) { nMinValue = nUserValue; } 
            }
            Console.WriteLine($"Минимальное значение из введенных чисел:{nMinValue}");
            Console.ReadKey();
        }
    }
}
