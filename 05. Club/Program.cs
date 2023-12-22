namespace _05._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            string cocktail = Console.ReadLine();
            double income = 0.0;

            while ("Party!" != cocktail)
            {
                int quantity = int.Parse(Console.ReadLine());

                int price = quantity * cocktail.Length;
                double finalPrice = price;
                if (price % 2 != 0)
                {
                    finalPrice *= 0.75;
                }
                income += finalPrice;
                target -= finalPrice;
                if (target <= 0)
                {
                    break;
                }

                cocktail = Console.ReadLine();
            }

            if ("Party!" == cocktail)
            {
                Console.WriteLine($"We need {target:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }

            Console.WriteLine($"Club income - {income:F2} leva.");
        }
    }
}