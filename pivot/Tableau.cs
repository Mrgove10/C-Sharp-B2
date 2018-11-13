using System;

namespace pivot
{
    internal class Tableau
    {
        static public int longtab = 10;
        static public int[,] tableau = new int[longtab, longtab];

        public void init()
        {
            inittableau();
            show();
            pivot();
            show();
        }

        static public void inittableau()
        {
            Console.WriteLine("Initialisation : ");
            Random rand = new Random();
            for (int i = 0; i < longtab; i++)
            {
                for (int j = 0; j < longtab; j++)
                {
                    tableau[i, j] = rand.Next(longtab);
                }
            }
        }

        private static void show()
        {
            for (int i = 0; i < longtab; i++)
            {
                for (int j = 0; j < longtab; j++)
                {
                    Console.Write(tableau[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----");
        }

        private static void pivot()
        {
            Console.WriteLine("pivot : ");

            for (int i = 0; i < longtab; i++)
            {
                for (int j = i; j < longtab; j++)
                {
                    var tempval = tableau[i, j];

                    var tempval2 = tableau[j, i];
                    tableau[j, i] = tempval;
                    tableau[i, j] = tempval2;
                }
            }
        }
    }
}