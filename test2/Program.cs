namespace test2
{
    internal class Program
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello adventurer welcome to the Femi Dungeon, are you willing to journey in for glory and riches (yes/yes)");
            string journey = Console.ReadLine();
            Console.WriteLine(" Alright first what is your name");
            string userName = Console.ReadLine();
            Console.WriteLine("what color do you prefer among all the colors in the spetrum of the universe");
            string color = Console.ReadLine();
            Console.WriteLine("who will be your trusty animal companion joining you on this adventure");
            string animal = Console.ReadLine();
            Console.WriteLine("Every great adventurer must have a great theme music what will be the song of choice");
            string music = Console.ReadLine();
            Console.WriteLine($"So the great adventures of {userName} begins at the steps of Femi's dungeon and almost immediatley our hero is confronted by Boobaloo" +
                $"the legendary {color} dragon. Boobaloo locks eyes with our mighty hero and {music} begins to play signifying its about to go down. Boobaloo shoots blast of fire " +
                $"in the direction of our hero {userName} but their trusty {animal} companion cast a magical spell to save their master. With their {animal} handling the defensive aspects " +
                $"the mighty her draws their sword and slashes the dragon but it does nothing and the dragon eats them up. THE END");

           int answer1 = Addition(50, 500);
            int answer2 = Multiplication(50, 500);
            int answer3 = Subtraction(50, 500);
            double answer4 = Division(50, 500);
            Console.WriteLine(answer1 + " " + answer2 + " " + answer3 + " " + answer4);
        }
        
        
    }   

}