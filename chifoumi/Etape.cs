using System;
using System.Collections.Generic;

namespace chifoumi
{
    internal class Etape
    {
        private posibilite PropositionJ1;
        private posibilite PropositionJ2;
        private Joueur EtapeWinner;
        private Verification VerificationEngine = new Verification();

        #region Getteur des different parametre, evite la triche en les gardant priver

        /// <summary>
        /// recupere la proposition du J1
        /// </summary>
        /// <returns></returns>
        public posibilite GetPropositionJ1()
        {
            return PropositionJ1;
        }

        /// <summary>
        /// recupere la proposition du J2
        /// </summary>
        /// <returns></returns>
        public posibilite GetPropositionJ2()
        {
            return PropositionJ2;
        }

        /// <summary>
        /// recupere le gagnant de l'etape
        /// </summary>
        /// <returns></returns>
        public Joueur GetGagant()
        {
            return EtapeWinner;
        }

        #endregion Getteur des different parametre, evite la triche en les gardant priver

        /// <summary>
        /// Posibilitées de jeu
        /// </summary>
        public enum posibilite
        {
            Feuille,
            Pierre,
            Ciseaux,
            Puit
        }

        /// <summary>
        /// Genere une etape de jeu
        /// </summary>
        /// <param name="J1"></param>
        /// <param name="J2"></param>
        public Etape(Joueur J1, Joueur J2, List<Etape> listEtapes)
        {
            EtapeWinner = VerificationEngine.verif(demandecoup(J1, listEtapes), J1, demandecoup(J2, listEtapes), J2);
            if (EtapeWinner == null)
            {
                Console.WriteLine("Egalité");
            }
            else
            {
                Console.WriteLine("winner : " + EtapeWinner.nom);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demande le coup du joueur
        /// </summary>
        /// <param name="Player"></param>
        /// <returns></returns>
        private posibilite demandecoup(Joueur Player, List<Etape> ListEtapes)
        {
            try
            {
                Console.WriteLine("Feuille = 0 | Pierre = 1 | Ciseaux = 2 | Puit = 3");
                if (Player.typePlayer == Joueur.type.Reel)
                {
                    Console.WriteLine("Coup de " + Player.nom + " (" + Player.typePlayer + ") :");
                    return (posibilite)int.Parse(Console.ReadLine());
                }

                if (Player.typePlayer == Joueur.type.Bot)
                {
                    Console.WriteLine("Coup de " + Player.nom + " :");
                    posibilite CoupBot = bot.random();
                    return CoupBot;
                }

                if (Player.typePlayer == Joueur.type.BotAI)
                {
                    Console.WriteLine("Coup de " + Player.nom + " :");
                    posibilite CoupBot = bot.playAI(ListEtapes);
                    return CoupBot;
                }
                Console.WriteLine();
                return demandecoup(Player, ListEtapes);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Mauvais format d'entree");
                Console.WriteLine();
                return demandecoup(Player, ListEtapes);
            }
        }
    }
}