namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра Угадай число!");
            Console.WriteLine("Введите верхнюю границу диапазона из которого загадать число:");
            int nMaxValue = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int nGuessNumber = rand.Next(1, nMaxValue);
            int nUserValue;
            while (true)
            {
                Console.WriteLine("Введите число:");
                string sUserValue = Console.ReadLine();
                if (sUserValue=="") 
                    {
                    Console.WriteLine($"Игра завершена досрочно. Загаданное число:{nGuessNumber}");
                    break;
                    }
                else { nUserValue = Convert.ToInt32(sUserValue); }
                if (nGuessNumber > nUserValue)
                {
                    Console.WriteLine("Введенное число меньше загадонного. Попробуйте еще раз:");
                }
                else if (nGuessNumber == nUserValue)
                {
                    Console.WriteLine("Вы угадали число!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Введенное число больше загадонного. Попробуйте еще раз!:");
                }
            }

        }
    }
}
