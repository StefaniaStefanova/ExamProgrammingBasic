namespace _08._Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());

            int totalPoints = 0;

            int totalWins = 0;
            int totalDraws = 0;

            for (int i = 0; i < gamesCount; i++)
            {
                string gameType = Console.ReadLine();

                if ("W" == gameType)
                {
                    totalPoints += 3;
                    totalWins++;
                }
                else if ("D" == gameType)
                {
                    totalPoints += 1;
                    totalDraws++;
                }
            }

            if (gamesCount == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                double winRate = totalWins * 1.0 / gamesCount * 100;

                Console.WriteLine($"{teamName} has won {totalPoints} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {totalWins}");
                Console.WriteLine($"## D: {totalDraws}");
                Console.WriteLine($"## L: {gamesCount - totalWins - totalDraws}");
                Console.WriteLine($"Win rate: {winRate:F2}%");
            }
        }
    }
}