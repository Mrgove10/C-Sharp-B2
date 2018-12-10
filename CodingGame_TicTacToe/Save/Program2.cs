/*

using System;
using System.Collections.Generic;

namespace CodingGame_TicTacToe
{
    public enum typesCase
    {
        Vide = 0,
        Croix = 1,
        Rond = 2
    }

    public class Case
    {
        public int posLigne;
        public int posColone;
        public typesCase typeCase;

        public Case(int posLigne_P, int posColone_P, typesCase typesCase_P)
        {
            posLigne = posLigne_P;
            posColone = posColone_P;
            typeCase = typesCase_P;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            int tourNumero = 0;
            int TbxSize = 9;
            typesCase Joueur = typesCase.Vide;
            typesCase Ennemi = typesCase.Vide;

            Case[,] tbxprinc = new Case[TbxSize, TbxSize];
            Random rand = new Random();

            //remplisage du tableau de case vide
            for (int m = 0; m < TbxSize; m++)
            {
                for (int n = 0; n < TbxSize; n++)
                {
                    tbxprinc[m, n] = new Case(m, n, typesCase.Vide);
                }
            }

            while (true)
            {
                string inputsrawLastPlayed = Console.ReadLine();
                if (tourNumero == 0) //si il s'agit Du premier tours
                {
                    if (inputsrawLastPlayed == "-1 -1") //1er a jouer = croix
                    {
                        Joueur = typesCase.Croix; // si je suis le premier je prend croix
                        Ennemi = typesCase.Rond;
                    }
                    else
                    {
                        Joueur = typesCase.Rond; // sinon je prend rond
                        Ennemi = typesCase.Croix;
                    }

                    Console.Error.WriteLine("vous etes : " + Joueur);
                    Console.Error.WriteLine("L'ennemi etes : " + Ennemi);
                    tourNumero++;
                }
                else
                {
                    tourNumero++;

                    string[] inputtbx = inputsrawLastPlayed.Split(' ');
                    int lEnnemie = Int32.Parse(inputtbx[0]);
                    int cEnnemie = Int32.Parse(inputtbx[1]);

                    tbxprinc[lEnnemie, cEnnemie].typeCase = Ennemi; //assigne le case jouer par el bode a une case dans mon tableaus
                    Console.Error.WriteLine("last enemy turn : " + tbxprinc[lEnnemie, cEnnemie].posColone + "," +
                                            tbxprinc[lEnnemie, cEnnemie].posLigne + "," +
                                            tbxprinc[lEnnemie, cEnnemie].typeCase);
                }

                List<Case> playable = new List<Case>();
                int NbPosib = Int32.Parse(Console.ReadLine());
                Console.Error.WriteLine("nb possible :" + NbPosib);
                for (int i = 0; i < NbPosib; i++)
                {
                    string[] splitLigne = Console.ReadLine().Split(' ');
                    int ligne = Int32.Parse(splitLigne[0]);
                    int col = Int32.Parse(splitLigne[1]);
                    Case currentCase = tbxprinc[ligne, col];
                    playable.Add(currentCase);
                }

                Case chose = playable[rand.Next(playable.Count)];
                tbxprinc[chose.posLigne, chose.posColone].typeCase = Joueur;

                Console.Error.WriteLine("randomly chose : " + chose.posLigne + " " + chose.posColone);
                Console.WriteLine(chose.posLigne + " " + chose.posColone);
            }
        }
    }
}

*/