using System;

namespace Exercice_9_1
{
    public class Game
    {
        private IConsole console;
        private Random random { get; set; }

        public Game(IConsole console/*, IRandom random*/)
        {
            this.console = console;
            //    this.random = random;
        }

        public void Start()
        {
            random = new Random();

            while (true)
            {
                ChiFouMi valeurJoueur = RecupererValeurJoueur();
                ChiFouMiObject valeurApplication = RecupererValeurApplication();

                if (valeurJoueur == valeurApplication.Value)
                    console.WriteLine("Egalité.");
                else if (valeurApplication.Bat(valeurJoueur))
                    console.WriteLine("L'ordinateur a gagné, il a joué : " + valeurApplication.Value.ToString());
                else
                    console.WriteLine("Bravo, vous avez gagné, il a joué : " + valeurApplication.Value.ToString());
            }
        }

        private ChiFouMi RecupererValeurJoueur()
        {
            console.WriteLine("Tapez 0 pour la pierre, 1 pour la feuille, 2 pour les ciseaux et 3 pour le puit.");
            int valeur = int.Parse(console.ReadLine());
            return (ChiFouMi)valeur;
        }

        private ChiFouMiObject RecupererValeurApplication()
        {
            ChiFouMi valeur = (ChiFouMi)random.Next(0, 4);

            if (valeur == ChiFouMi.Ciseaux)
                return CreateChiFouMiObject<Ciseaux>();
            else if (valeur == ChiFouMi.Feuille)
                return CreateChiFouMiObject<Feuille>();
            else if (valeur == ChiFouMi.Pierre)
                return CreateChiFouMiObject<Pierre>();
            else if (valeur == ChiFouMi.Puit)
                return CreateChiFouMiObject<Puit>();
            else
                return null;
        }

        private ChiFouMiObject CreateChiFouMiObject<T>() where T : ChiFouMiObject, new()
        {
            return new T();
        }
    }
}