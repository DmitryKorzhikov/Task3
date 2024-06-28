namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какое количество карт у Вас на руках?");
            int nQTYCards = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= nQTYCards; i++)
            {
                Console.WriteLine($"Введите какая карта #{i}");
                string sCard = Console.ReadLine();
                
                switch (sCard.ToUpper())
                {
                    case "J":
                        sum = sum + 10;
                        break;
                    case "Q":
                        sum = sum + 10;
                        break;
                    case "K":
                        sum = sum + 10;
                        break;
                    case "T":
                        sum = sum + 10;
                        break;
                    default:
                        sum = sum + int.Parse(sCard);
                        break;
                }
            }
            Console.WriteLine($"Сумма карт игрока = {sum}");

        }
    }
}
