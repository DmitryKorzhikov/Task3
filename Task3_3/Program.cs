namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int digit = int.Parse(Console.ReadLine());
            bool bSimple = false;
            for (int i = 2; i<digit;i++)
            {
                if (digit % i == 0) {bSimple = true;}
                Console.WriteLine($"остаток от деления {digit,4}/{i} = {digit % i}");
            }
            Console.WriteLine($"bSimple={bSimple}");
            if (bSimple==false) { Console.WriteLine("Число является простым"); }
            else { Console.WriteLine("Число неявляется простым"); }
        }
    }
}
