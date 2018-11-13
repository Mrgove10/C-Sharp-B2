using System;

namespace wheeeee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                jeu MainJeu = new jeu();
                MainJeu.STARTGENERAL();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}