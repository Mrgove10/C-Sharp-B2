using System;
using System.Collections.Generic;
using System.Linq;

namespace chifoumi
{
    internal static class bot
    {
        /// <summary>
        /// methode de jeu automatique
        /// </summary>
        /// <returns>valeur que le bot a choisi</returns>
        public static Etape.posibilite random()
        {
            Random n = new Random();
            int val = n.Next(0, 4);
            Console.WriteLine((Etape.posibilite)val);

            return (Etape.posibilite)val;
        }

        // https://motherboard.vice.com/fr/article/8q5na3/pourquoi-on-est-mauvais-a-pierre-feuille-ciseaux-et-comment-devenir-meilleur

        /*
         Si votre adversaire l'a emporté au tour précédent, jouez une main qui bat sa main précédente (ex. : ciseaux s'il a joué feuille).
        S'il a perdu, jouez la main qu'il vient de jouer (puisqu'il risque de jouer la main « inférieure »).
        S'il y a eu match nul, jouez une main « inférieure » à celle qu'il vient de jouer, puisqu'il va sûrement en changer et qu'a priori vous aurez l'avantage.*/

        /// <summary>
        /// Mini inteligence artificiel
        /// </summary>
        /// <param name="Etapes"></param>
        /// <returns></returns>
        public static Etape.posibilite playAI(List<Etape> Etapes)
        {
            Etape DerniereEtap = null;
            //si il s'agit de la premiere etape il ets obliger de jouer de facon random
            if (Etapes == null || Etapes.Count <= 0)
            {
                return random();
            }
            DerniereEtap = Etapes.Last();
            Etape.posibilite Choix = new Etape.posibilite();

            if (DerniereEtap.GetGagant() == null)
            {
                //S'il y a eu match nul, jouez une main « inférieure » à celle qu'il vient de jouer, puisqu'il va sûrement en changer et qu'a priori vous aurez l'avantage.*/

                switch (DerniereEtap.GetPropositionJ1())
                {
                    case Etape.posibilite.Feuille:
                        Choix = Etape.posibilite.Pierre; //ou puit
                        break;

                    case Etape.posibilite.Pierre:
                        Choix = Etape.posibilite.Ciseaux;
                        break;

                    case Etape.posibilite.Ciseaux:
                        Choix = Etape.posibilite.Feuille;
                        break;

                    case Etape.posibilite.Puit:
                        Choix = Etape.posibilite.Pierre; //ou ciseai
                        break;

                    default:
                        break;
                }
            }
            else if (DerniereEtap.GetGagant().typePlayer == Joueur.type.Reel) //si la derniere main a ete gagner par le joueur reel
            {
                // Si votre adversaire l'a emporté au tour précédent, jouez une main qui bat sa main précédente (ex. : ciseaux s'il a joué feuille).
                switch (DerniereEtap.GetPropositionJ1())
                {
                    case Etape.posibilite.Feuille:

                        Choix = Etape.posibilite.Ciseaux;
                        break;

                    case Etape.posibilite.Pierre:

                        //                        Rand.Next(Etape.posibilite.Puit, Etape.posibilite.Feuille);
                        Choix = Etape.posibilite.Puit; //ou feuile
                        break;

                    case Etape.posibilite.Ciseaux:
                        Choix = Etape.posibilite.Pierre; //ou puit
                        break;

                    case Etape.posibilite.Puit:
                        Choix = Etape.posibilite.Feuille;
                        break;

                    default:
                        break;
                }
            }
            else if (DerniereEtap.GetGagant().typePlayer == Joueur.type.BotAI)
            {
                // S'il a perdu, jouez la main qu'il vient de jouer(puisqu'il risque de jouer la main « inférieure »).
                Choix = DerniereEtap.GetPropositionJ1();
            }

            Console.WriteLine((int)Choix);
            return Choix;
        }
    }
}