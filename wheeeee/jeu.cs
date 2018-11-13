using System;
using System.Collections.Generic;
using System.Linq;

namespace wheeeee
{
    public class jeu
    {
        public List<escargot> ListEscargot = new List<escargot>();
        public de _de = new de();

        public void STARTGENERAL()
        {
            AffichageInit();
            CreationEscargot();
            race();
            Console.ReadLine();
        }

        public void race()
        {
            bool course = true;
            while (course)
            {
                foreach (var esc in ListEscargot)
                {
                    Console.ForegroundColor = esc.couleur;
                    esc.avanceEsc(esc);
                    Console.ResetColor();

                    if (esc.distance > 25)
                    {
                        course = false;
                    }
                }

                Console.WriteLine("-----");
            }

            //     var escargot = ListEscargot.Select(x => x.).Max(x => x.distance);
            var escargot = ListEscargot.OrderByDescending(x => x.distance).FirstOrDefault();
            Console.WriteLine(escargot.name + " est arriver le plus loin");
        }

        /*   public  void Initrace(int nbescargot)
           {
               Console.WriteLine("debut de la course");
               for (int i = 0; i < nbescargot; i++)
               {
                   Console.WriteLine("_____@I=========================I_____");
               }
           }*/

        public void AffichageInit()
        {
            Console.WriteLine("Escargot race");
        }

        public void CreationEscargot()
        {
            Console.WriteLine("Nombre d'escargot souhaiter :");
            var nbescargot = Console.ReadLine();

            for (int j = 0; j < Int32.Parse(nbescargot); j++)
            {
                ListEscargot.Add(new escargot(new tortue()));
            }
        }
    }
}