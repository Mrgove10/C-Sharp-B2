using System;
using System.Collections.Generic;

namespace chifoumi
{
    internal class Jeu
    {
        private Joueur J1;
        private Joueur J2;
        private List<Etape> EnchainementEtapes = new List<Etape>();

        /// <summary>
        /// Affichage du menu principale
        /// </summary>
        public void menu()
        {
            Console.WriteLine("Shi-Fou-Mi");
            Console.WriteLine("1 : parti classic 2 joueur");
            Console.WriteLine("2 : parti contre bot random");
            Console.WriteLine("3 : parti bot intéligent");

            switch (Console.ReadLine())
            {
                case "1":
                    GameWith2Players();
                    break;

                case "2":
                    GameWhitBot();
                    break;

                case "3":
                    GameWhitBotAI();
                    break;
            }
        }

        /// <summary>
        /// Jeu avec deux joueurs humain differents
        /// </summary>
        public void GameWith2Players()
        {
            PlayerInit("Standard");
            EnchainementEtapes = new List<Etape>();
            while (true)
            {
                Etape CurrentStep = new Etape(J1, J2, EnchainementEtapes);
                EnchainementEtapes.Add(CurrentStep);
            }
        }

        /// <summary>
        /// Jeu avec le bot
        /// </summary>
        public void GameWhitBot()
        {
            PlayerInit("Bot");
            while (true)
            {
                Etape CurrentStep = new Etape(J1, J2, EnchainementEtapes);
                EnchainementEtapes.Add(CurrentStep);
            }
        }

        /// <summary>
        /// Jeu avec le bot AI
        /// </summary>
        public void GameWhitBotAI()
        {
            PlayerInit("BotAI");
            while (true)
            {
                Etape CurrentStep = new Etape(J1, J2, EnchainementEtapes);
                EnchainementEtapes.Add(CurrentStep);
            }
        }

        /// <summary>
        /// Initialisation des deux jouer dans lecas d'une parti normal
        /// </summary>
        public void PlayerInit(string mode)
        {
            Console.WriteLine("Nom du joueur 1");
            var tempnomJ1 = Console.ReadLine();
            J1 = new Joueur(tempnomJ1, Joueur.type.Reel);

            if (mode == "Standard")
            {
                Console.WriteLine("Nom du joueur 2");
                var tempnomJ2 = Console.ReadLine();
                J2 = new Joueur(tempnomJ2, Joueur.type.Reel);
            }

            if (mode == "Bot")
            {
                J2 = new Joueur("Bot", Joueur.type.Bot);
            }

            if (mode == "BotAI")
            {
                J2 = new Joueur("BotAI", Joueur.type.BotAI);
            }
        }
    }
}