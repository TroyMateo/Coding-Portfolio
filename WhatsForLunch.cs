using System;

namespace WhatsForLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            const int American = 0;
            const int Mexican = 1;
            const int Asian = 2;
            const int Italian = 3;
            
            //Asks what's for lunch today
            Console.WriteLine("What's for lunch today?");

            //Creates a jagged array of different genres of food
            string[][] lunch = new string[4][];

            //American food
            lunch[American] = new string[] { "McDonalds", "BurgerKing", "Wendys", "Dicks", "RedRobin", "FiveGuys", "KFC", "ChicFilA", "Popeyes" };
            //Mexican
            lunch[Mexican] = new string[] { "TacoTime", "Qdoba", "Chipotle", "TacoBell", "TacoTruck", "ElParaiso" };
            //Asian
            lunch[Asian] = new string[] {"Chinese", "Thai", "Filipino", "Indian", "Japanese", "Vietnamese"};
            //Italian
            lunch[Italian] = new string[] {"OliveGarden", "SpaghettiFactory", "BucadaBepos"};

            bool tryAgain = true;
            Random rndm = new Random();            

            while (tryAgain)
            {
                //Selects genre of food at random
                int x = rndm.Next(lunch.Length);
                //Selects lunch location at random
                int y = rndm.Next(lunch[x].Length);

                Console.WriteLine("Lunch today is: {0}", lunch[x][y]);

                //Asks if the user is ok with the selection
                Console.WriteLine("Is this ok? y|n?");
                //Reevaluates the boolean value based on the answer
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    tryAgain = false;
                }
                else
                {
                    tryAgain = true;
                }
            }
        }
    }
}
