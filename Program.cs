namespace Exquisite_Corpse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BuildACreature("ghost", "bug", "monster");
            //SwitchCase(1, 1, 1);
            RandomMode();
        }

        static void BuildACreature(string head, string body, string feet)
        {
            switch (head)
            {
                case "bug":
                    BugHead();
                    break;
                case "monster":
                    MonsterHead();
                    break;
                case "ghost":
                    GhostHead();
                    break;
                default:
                    Console.WriteLine($"what");
                    break;
            }
            switch (body)
            {
                case "bug":
                    BugBody();
                    break;
                case "monster":
                    MonsterBody();
                    break;
                case "ghost":
                    GhostBody();
                    break;
                default:
                    Console.WriteLine($"what");
                    break;
            }
            switch (feet)
            {
                case "bug":
                    BugFeet();
                    break;
                case "monster":
                    MonsterFeet();
                    break;
                case "ghost":
                    GhostFeet();
                    break;
                default:
                    Console.WriteLine($"what");
                    break;
            }
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    BugHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    GhostHead();
                    break;
                default:
                    Console.WriteLine($"what");
                    break;
            }
            switch (body)
            {
                case 1:
                    BugBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    GhostBody();
                    break;
                default:
                    Console.WriteLine($"what");
                    break;
            }
            switch (feet)
            {
                case 1:
                    BugFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                case 3:
                    GhostFeet();
                    break;
                default:
                    Console.WriteLine($"what");
                    break;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}