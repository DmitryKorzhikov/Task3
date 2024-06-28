namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число, которые Вы ввели: {digit}") ;
            if (digit % 2 == 0) { Console.WriteLine("Число четное"); }
            else { Console.WriteLine("Число нечетное"); };
            
            Console.ReadKey();
        }
    }
}
