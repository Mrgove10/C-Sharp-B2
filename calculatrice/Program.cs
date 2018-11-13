using System;
using System.Collections.Generic;
using System.Linq;

namespace calculatrice
{
    internal class Program
    {
        public List<calcul.IOperation> operations = new List<calcul.IOperation>
        {
            new calcul.addition(),
            new calcul.soustraction(),
            new calcul.multiplication(),
            new calcul.division()
        };
        /// <summary>
        /// fonction  principale
        /// </summary>
        /// <param name="args">arguments</param>
        private static void Main(string[] args)
        {
            try
            {
               

                saisieValeur();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("oups sa a planté");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Effectue le calcule en fonction du parametre
        /// </summary>
        /// <param name="signe">Type de calcule a effectuer</param>
        public static void RoutineCalcule(string signe, float C1, float C2)
        {
            calcul c =new calcul();
       /*     calcul.IOperation = operations.First()

            else
            {
                Console.WriteLine("Opperation non reconnue");
                Console.ReadLine();
            }*/
            
        }

        /// <summary>
        /// sasie de la valeur
        /// </summary>
        public static void saisieValeur()
        {
            try
            {
                Console.WriteLine("chiffre1");
                var C1 = float.Parse(Console.ReadLine());

                Console.WriteLine("type d'offeration a effectuer");
                var selection = Console.ReadLine();

                Console.WriteLine("chiffre2");
                var C2 = float.Parse(Console.ReadLine());

                Console.WriteLine("resultat");

                RoutineCalcule(selection, C1, C2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}