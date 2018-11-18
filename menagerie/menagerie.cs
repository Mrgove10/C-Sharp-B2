using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace menagerie
{
    internal class menagerie
    {
        public List<Animal> ListAnimaux = new List<Animal>(); //list de tous les animaux
        private int RaceLength = 45; // longuer de la course
        private Affichage AffichageEngine = new Affichage();

        /// <summary>
        /// Constructeur de la menagerie
        /// </summary>
        public void CreationMenagerie()
        {
            // debugInit(); //Ajout d'animaux automatique de debuggage
            menu();
        }

        /// <summary>
        /// Affichage du menu principale
        /// </summary>
        public void menu()
        {
            var IsChoosing = true;

            Console.WriteLine("------");
            Console.WriteLine("1 : List");
            Console.WriteLine("2 : Ajout");
            Console.WriteLine("3 : Course");
            Console.WriteLine("0 : Exit");
            while (IsChoosing)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        AffichageEngine.affichageList(ListAnimaux);
                        menu();
                        break;

                    case "2":
                        ajout();
                        menu();
                        break;

                    case "3":
                        if (ListAnimaux.Count < 5)
                        {
                            Console.WriteLine("Vous n'avez pas asse d'animaux, ajoutez s'en plus !");
                        }
                        else
                        {
                            race();
                        }
                        menu();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        menu();
                        break;
                }
            }
        }

        /// <summary>
        /// Ajout d'un animal
        /// </summary>
        public void ajout()
        {
            Console.WriteLine("Ajouter votre animal");
            Console.WriteLine("Type : ");
            string TempType = Console.ReadLine();
            Console.WriteLine("Nom : ");
            string TempNom = Console.ReadLine();

            IAnimal TestName = ListAnimaux.Single(s => s.Nom == TempNom);
            if (TestName != null)
            {
                Console.WriteLine("Error : il ne peut pas y avoir deux animaux avec le meme nom");
                ajout();
            }

            switch (TempType)
            {
                case "Poussin":
                    ListAnimaux.Add(new Poussin(TempNom));
                    break;

                case "Chat":
                    ListAnimaux.Add(new Chat(TempNom));
                    break;

                case "Chien":
                    ListAnimaux.Add(new Chien(TempNom));
                    break;

                case "Dindon":
                    ListAnimaux.Add(new Dindon(TempNom));
                    break;

                case "Taureau":
                    ListAnimaux.Add(new Taureau(TempNom));
                    break;

                case "Vache":
                    ListAnimaux.Add(new Vache(TempNom));
                    break;

                default:
                    ajout();
                    break;
            }
        }

        /// <summary>
        /// course entre les animaux
        /// </summary>
        public void race()
        {
            bool IsRacing = true;
            int tours = 0;
            foreach (var Ani in ListAnimaux) //remplisage dictionaire
            {
                Ani.PositionCourse = 0;
            }

            while (IsRacing)
            {
                tours++;
                Console.Clear();
                Console.WriteLine("Tour numero : " + tours);
                Random Dice = new Random(); // a cause du truc qu'il est pas vraiment random
                foreach (var Ani in ListAnimaux)
                {
                    int pos = Ani.PositionCourse;
                    pos = pos + CalculePos(Ani, tours, Dice);
                    Ani.PositionCourse = pos;
                    if (pos >= RaceLength)
                    {
                        IsRacing = false;
                    }

                    AffichageEngine.stringcreator(Ani, pos, RaceLength);
                }

                Thread.Sleep(500); //pour rendre l'animation moin rapide
            }

            var winner = ListAnimaux.OrderByDescending(s => s.PositionCourse).First();
            Console.WriteLine("Winner is : " + winner.Nom);
        }

        /// <summary>
        /// Calcule lanouvelle position de chaque animal
        /// </summary>
        /// <param name="aniCurrent"></param>
        /// <param name="tours"></param>
        /// <param name="deRandom"></param>
        /// <returns></returns>
        public int CalculePos(Animal aniCurrent, int tours, Random deRandom)
        {
            int Pas = deRandom.Next(1, 7);//for everyone

            if (aniCurrent.GetType().Name == "Poussin")// cas du Poussin
            {
                try
                {
                    int posdindon = ListAnimaux.First(a => a.GetType().Name == "Dindon").PositionCourse;

                    if (aniCurrent.PositionCourse < posdindon)
                    {
                        Pas = Pas + 2;
                        Console.WriteLine("Bonus Poussin !");
                    }
                }
                catch
                {
                    return Pas;
                }
            }
            if (aniCurrent.GetType().Name == "Chat")// cas du Chat
            {
                try
                {
                    int posChien = ListAnimaux.First(a => a.GetType().Name == "Chien").PositionCourse;
                    if (posChien > aniCurrent.PositionCourse)
                    {
                        Pas = Pas + 1;
                        Console.WriteLine("Bonus Chat !");
                    }
                }
                catch
                {
                    return Pas;
                }
            }
            if (aniCurrent.GetType().Name == "Vache")// cas du Vache
            {
                try
                {
                    int posChien = ListAnimaux.First(a => a.GetType().Name == "Chien").PositionCourse;
                    if (posChien > aniCurrent.PositionCourse)
                    {
                        Pas = Pas + 2;
                        Console.WriteLine("Bonus Vache !");
                    }
                }
                catch
                {
                    return Pas;
                }
            }
            if (aniCurrent.GetType().Name == "Taureau" && tours > 1)// cas du Taureau
            {
                try
                {
                    if (aniCurrent == ListAnimaux.OrderBy(s => s.PositionCourse).First())
                    {
                        Pas = Pas + 3;
                        Console.WriteLine("Bonus Taureau !");
                    }
                }
                catch
                {
                    return Pas;
                }
            }
            if (aniCurrent.GetType().Name == "Dindon")// cas du Dindon
            {
                try
                {
                    int posChien = ListAnimaux.First(a => a.GetType().Name == "Chien").PositionCourse;
                    if (aniCurrent.PositionCourse < posChien)
                    {
                        Pas = Pas - 1;
                        Console.WriteLine("Bonus Dindon !");
                    }
                }
                catch
                {
                    return Pas;
                }
            }
            if (aniCurrent.GetType().Name == "Chien" && tours % 4 == 0)// cas du Chien
            {
                Pas = 0;
                Console.WriteLine("Bonus Chien !");
            }

            return Pas;
        }

        /// <summary>
        /// Remplisage automatique de la list d'animaux (For debug Purposes)
        /// </summary>
        public void debugInit()
        {
            ListAnimaux.Add(new Chat("Chat"));
            ListAnimaux.Add(new Chien("Chien"));
            ListAnimaux.Add(new Vache("Vache"));
            ListAnimaux.Add(new Taureau("Taureau"));
            ListAnimaux.Add(new Dindon("Dindon"));
        }
    }
}