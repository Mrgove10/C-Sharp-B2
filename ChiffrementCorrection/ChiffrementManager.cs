using System;

namespace ChiffrementCorrection
{
    internal class ChiffrementManager
    {
        public void Start()
        {
            Console.WriteLine("Entrez un texte à chiffrer :");
            string valeur = Console.ReadLine();

            Console.WriteLine("Entrez une valeur de décalage :");
            int decalage = int.Parse(Console.ReadLine());

            ICesar chiffrer = new ChiffrementCesar();
            Console.WriteLine("Résultat :" + chiffrer.ChiffreOuDechiffreMot(valeur, decalage));

            ICesar dechiffrer = new DechiffrementCesar();
            Console.WriteLine("Résultat :" + dechiffrer.ChiffreOuDechiffreMot(valeur, decalage));
        }
    }
}