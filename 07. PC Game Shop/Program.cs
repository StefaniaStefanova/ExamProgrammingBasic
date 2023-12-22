namespace _07._PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hearhstoneCnt = 0;
            int forniteCnt = 0;
            int overwatchCnt = 0;
            int otherGamesCnt = 0;

            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone":
                        hearhstoneCnt++;
                        break;
                    case "Fornite":
                        forniteCnt++;
                        break;
                    case "Overwatch":
                        overwatchCnt++;
                        break;
                    default:
                        otherGamesCnt++;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {(hearhstoneCnt * 1.0 / n * 100):F2}%");
            Console.WriteLine($"Fornite - {(forniteCnt * 1.0 / n * 100):F2}%");
            Console.WriteLine($"Overwatch - {(overwatchCnt * 1.0 / n * 100):F2}%");
            Console.WriteLine($"Others - {(otherGamesCnt * 1.0 / n * 100):F2}%");
        }
    }
}