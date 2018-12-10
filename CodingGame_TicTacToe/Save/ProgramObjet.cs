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
        public int PosLigne;
        public int PosColone;
        public typesCase typeCase;

        public Case(int posLigne_P, int posColone_P, typesCase typesCase_P)
        {
            PosLigne = posLigne_P;
            PosColone = posColone_P;
            typeCase = typesCase_P;
        }
    }

    public class Game
    {
        public static IConsole Console { get; set; }

        public Game(IConsole console)
        {
            Console = console;
        }

        /// <summary>
        /// Initialises the type of the first player
        /// </summary>
        /// <param name="inputsrawLastPlayed"></param>
        /// <param name="Joueur"></param>
        /// <param name="Ennemi"></param>
        public static void SetJoueurTour1(string inputsrawLastPlayed, typesCase Joueur, typesCase Ennemi)
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

            Console.WriteErrorLine("vous etes : " + Joueur);
            Console.WriteErrorLine("L'ennemi etes : " + Ennemi);
        }

        /// <summary>
        /// Convers a sring to a int tableau
        /// </summary>
        /// <param name="InputString"></param>
        /// <returns></returns>
        public static int[] StringToInt(string InputString)
        {
            string[] inputtbx = InputString.Split(' ');
            int LigneEnnemie = Int32.Parse(inputtbx[0]);
            int ColoneEnnemie = Int32.Parse(inputtbx[1]);
            int[] inputtbxint = { LigneEnnemie, ColoneEnnemie };
            return inputtbxint;
        }
            


        public void Start()
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
                    Game.SetJoueurTour1(inputsrawLastPlayed, Joueur, Ennemi);
                    tourNumero++;
                }
                else
                {
                    tourNumero++;
                    tbxprinc[Game.StringToInt(inputsrawLastPlayed)[0], Game.StringToInt(inputsrawLastPlayed)[1]].typeCase = Ennemi;//assigne le case jouer par el bode a une case dans mon tableaus
                    Console.WriteErrorLine("last enemy turn : " + tbxprinc[0, 1].PosColone + "," +
                                            tbxprinc[0, 1].PosLigne + "," +
                                            tbxprinc[0, 1].typeCase);
                }

                List<Case> playable = new List<Case>();
                int NbPosib = Int32.Parse(Console.ReadLine());
                Console.WriteErrorLine("nb possible :" + NbPosib);
                for (int i = 0; i < NbPosib; i++)
                {
                    string splitLigne = Console.ReadLine();
                    Case currentCase = tbxprinc[Game.StringToInt(splitLigne)[0], Game.StringToInt(splitLigne)[1]];
                    playable.Add(currentCase);
                }

                Case chose = playable[rand.Next(playable.Count)];
                tbxprinc[chose.PosLigne, chose.PosColone].typeCase = Joueur;

                Console.WriteErrorLine("randomly chose : " + chose.PosLigne + " " + chose.PosColone);
                Console.WriteLine(chose.PosLigne + " " + chose.PosColone);
            }
        }
    }
    
    public class Program
    {
        private static void Main(string[] args)
        {
            Game MG = new Game(new TrueConsole());
            MG.Start();
        }
    }
}*/