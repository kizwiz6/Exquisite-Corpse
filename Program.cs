namespace Exquisite_Corpse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildACreature("ghost", "monster", "bug");
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