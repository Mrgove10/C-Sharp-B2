using System;

namespace wheeeee
{
    public class escargot
    {
        private de rand = new de();
        public string id { get; set; }
        public string name { get; set; }
        public int distance { get; set; }

        public tortue tortue { get; set; }
        public ConsoleColor couleur { get; set; }

        public escargot(tortue Tortue)
        {
            tortue = Tortue;
            Guid GuidGenerator = new Guid();
            id = GuidGenerator.ToString();

            Console.WriteLine("Nom de L'escargot");
            name = Console.ReadLine();
            couleur = ConsoleColor.White;
            /*
              var consoleColors = Enum.GetValues(typeof(ConsoleColor));
               var randchoose = (ConsoleColor)consoleColors.GetValue(rand.Next(consoleColors.Length));
               if (randchoose != ConsoleColor.Black)
               {
                   couleur = randchoose;
               }*/

            distance = 0;
        }

        public void avanceEsc(escargot P_escargot)
        {
            int cases = rand.lancee(5);
            P_escargot.distance += cases;
            P_escargot.distance += tortue.bonus;
            Console.WriteLine(P_escargot.name + " a avancer de " + cases + "(" + (25 - P_escargot.distance) + ") | " + tortue.bonus);
        }
    }
}