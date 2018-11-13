using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace biblio
{
    internal class Program
    {
        //biblio general
        public static List<Livre> Bibio = new List<Livre>();

        // chemin d'acces au fichier
        public static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\data.txt";

        /// <summary>
        /// Methode principale
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            try
            {
                AffichageArt();
                Menu();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// ajouter un livre
        /// </summary>
        private static void AjoutLivre()
        {
            if (Bibio.Count < 10)
            {
                Console.WriteLine("titre");
                var titretmp = Console.ReadLine();
                Console.WriteLine("anee");
                var aneetmp = Console.ReadLine();
                Console.WriteLine("nb de pages");
                var pagetmp = Console.ReadLine();
                Livre livre = new Livre(titretmp, Int32.Parse(aneetmp), Int32.Parse(pagetmp));

                int pageTot = Bibio.Sum(v => v.NbdePage);
                int tempajoutPage = pageTot + Int32.Parse(pagetmp);
                if (tempajoutPage >= 2000)
                {
                    Console.WriteLine("Ajout imposible : ajouter ce livre depasserais le nombre de page maximum accepter (" + tempajoutPage + " / 2000 Pages)");
                }
                else if (pageTot >= 2000)
                {
                    Console.WriteLine("Ajout imposible : il y a deja le nombre maximum de pages en bibliotech (" + pageTot + " Pages)");
                }
                else
                {
                    Bibio.Add(livre);
                }
            }
            else
            {
                Console.WriteLine("Ajout imposible : il y a deja le nombre maximum de livre en bibliotech (" + Bibio.Count + " Livres)");
            }
        }

        /// <summary>
        /// suppression d'eun livre
        /// </summary>  
        private static void SuppresionLivre()
        {
            if (Bibio.Count > 1)
            {
                Console.WriteLine("Livre actuelement dans la bilio :");
                foreach (var livre in Bibio)
                {
                    Console.WriteLine("\nid : " + livre.id + ", Titre : " + livre.titre);
                }
                Console.WriteLine("ID du livre  modifier :");
                var id = Console.ReadLine();
                Livre livretodelete = Bibio.Where(x => x.id == id).FirstOrDefault();
                Bibio.Remove(livretodelete);
                Sauvegarde();
            }
            else
            {
                Console.WriteLine("Il n'y a aucun livre a supprimer");
            }
        }

        /// <summary>
        /// Permet de modifier un livre
        /// </summary>
        private static void ModLivre()
        {
            Console.WriteLine("Livre actuelement dans la bilio :");
            foreach (var livre in Bibio)
            {
                Console.WriteLine("\nid : " + livre.id + ", Titre : " + livre.titre);
            }
            Console.WriteLine("ID du livre  modifier :");
            string IDLivreToMod = Console.ReadLine();

            Livre LivreToMod = Bibio.Where(l => l.id == IDLivreToMod).FirstOrDefault();

            Console.WriteLine("\nTitre : [" + LivreToMod.titre + "]");
            Console.WriteLine("nouvelle valeur : ");
            string TitreMod = Console.ReadLine();
            if (!String.IsNullOrEmpty(TitreMod))
            {
                LivreToMod.titre = TitreMod;
            }

            Console.WriteLine("\nnb de page : [" + LivreToMod.NbdePage + "]");
            Console.WriteLine("nouvelle valeur : ");
            string nbpageMod = Console.ReadLine();
            if (!String.IsNullOrEmpty(nbpageMod))
            {
                int pageTot = Bibio.Sum(v => v.NbdePage);
                int tempajoutPage = pageTot + Int32.Parse(nbpageMod);
                if (tempajoutPage >= 2000)
                {
                    Console.WriteLine("Ajout imposible : ajouter ce livre depasserais le nombre de page maximum accepter (" + tempajoutPage + " / 2000 Pages)");
                }
                else if (pageTot >= 2000)
                {
                    Console.WriteLine("Ajout imposible : il y a deja le nombre maximum de pages en bibliotech (" + pageTot + " Pages)");
                }
                else
                {
                    LivreToMod.NbdePage = Int32.Parse(nbpageMod);
                }
            }

            Console.WriteLine("\ndate publication : [" + LivreToMod.datePublication + "]");
            Console.WriteLine("nouvelle valeur : ");
            string dateMod = Console.ReadLine();
            if (!String.IsNullOrEmpty(dateMod))
            {
                LivreToMod.datePublication = Int32.Parse(dateMod);
            }
            Sauvegarde();
        }

        /// <summary>
        /// Affiche la bibilotech complete
        /// </summary>
        private static void affichagebiblio()
        {
            if (Bibio.Count == 0)
            {
                Console.WriteLine("Bibiotech Vide");
            }
            else
            {
                foreach (var livre in Bibio)
                {
                    Console.WriteLine("┌─────────────────┬────────────────────────────────────────┐");
                    Console.WriteLine("│ID               │ " + livre.id);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Titre            │ " + livre.titre);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Nb de page       │ " + livre.NbdePage);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Date publication │ " + livre.datePublication);
                    Console.WriteLine("└─────────────────┴────────────────────────────────────────┘");
                }
            }
        }

        /// <summary>
        /// affichage de la biblio en  fonction de la date de publication
        /// </summary>
        private static void affichagebiblioAnee()
        {
            if (Bibio.Count == 0)
            {
                Console.WriteLine("Bibiotech Vide");
            }
            else
            {
                List<Livre> tmplist = new List<Livre>();
                tmplist = Bibio;
                tmplist = tmplist.OrderBy(x => x.datePublication).ToList();
                foreach (var livre in tmplist)
                {
                    Console.WriteLine("┌─────────────────┬────────────────────────────────────────┐");
                    Console.WriteLine("│ID               │ " + livre.id);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Titre            │ " + livre.titre);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Nb de page       │ " + livre.NbdePage);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Date publication │ " + livre.datePublication);
                    Console.WriteLine("└─────────────────┴────────────────────────────────────────┘");
                }
            }
        }

        /// <summary>
        /// affichage de la biblio en  fonction du nombre de pages
        /// </summary>
        private static void affichagebiblioPage()
        {
            if (Bibio.Count == 0)
            {
                Console.WriteLine("Bibiotech Vide");
            }
            else
            {
                List<Livre> tmplist = new List<Livre>();
                tmplist = Bibio;
                tmplist = tmplist.OrderBy(x => x.NbdePage).ToList();

                foreach (var livre in tmplist)
                {
                    Console.WriteLine("┌─────────────────┬────────────────────────────────────────┐");
                    Console.WriteLine("│ID               │ " + livre.id);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Titre            │ " + livre.titre);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Nb de page       │ " + livre.NbdePage);
                    Console.WriteLine("├─────────────────┼────────────────────────────────────────┤");
                    Console.WriteLine("│Date publication │ " + livre.datePublication);
                    Console.WriteLine("└─────────────────┴────────────────────────────────────────┘");
                }
            }
        }

        /// <summary>
        /// sauvegarde des donnne au format json dans un fichier text
        /// </summary>
        private static void Sauvegarde()
        {
            string json = JsonConvert.SerializeObject(Bibio.ToArray());

            System.IO.File.WriteAllText(dir, json);
        }

        /// <summary>
        /// lecture du fichier text avec decriptage du json
        /// </summary>
        private static void lecture()
        {
            string text = System.IO.File.ReadAllText(dir);
            Bibio = JsonConvert.DeserializeObject<List<Livre>>(text);
        }

        /// <summary>
        /// Affichage de l'asci art
        /// </summary>
        private static void AffichageArt()
        {
            Console.WriteLine(" ____  _ _     _ _");
            Console.WriteLine("|  _ \\(_) |   | (_)");
            Console.WriteLine("| |_) |_| |__ | |_  ___");
            Console.WriteLine("|  _ <| | '_ \\| | |/ _ \\ ");
            Console.WriteLine("| |_) | | |_) | | | (_) |");
            Console.WriteLine("|____/|_|_.__/|_|_|\\___/");

            Console.WriteLine("Initialisation");
            System.Threading.Thread.Sleep(1000);
            string loadingstring = "0..........25..........50..........75..........100";

            Random r = new Random();
            foreach (char c in loadingstring)
            {
                if (c == '.')
                {
                    int rr = r.Next(10, 150);
                    System.Threading.Thread.Sleep(rr);
                    Console.Write(c);
                }
                else
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Affichage du menu
        /// </summary>
        private static void Menu()
        {
            lecture();
            Console.WriteLine("┌───┬─────────────────────────────┐");
            Console.WriteLine("│ 1 │ Afficher la biblio          │");
            Console.WriteLine("│ 2 │ Ajout d'un livre            │");
            Console.WriteLine("│ 3 │ Supprimer d'un livre        │");
            Console.WriteLine("│ 4 │ Lister par date publication │");
            Console.WriteLine("│ 5 │ Lister par pages            │");
            Console.WriteLine("│ 6 │ Modifier un livre existant  │");
            Console.WriteLine("│ 7 │ Quitter l'application       │");
            Console.WriteLine("└───┴─────────────────────────────┘");
            var tmpinput = Console.ReadLine();
            switch (tmpinput)
            {
                case "1":
                    affichagebiblio();
                    Console.WriteLine();
                    Menu();
                    break;

                case "2":
                    AjoutLivre();
                    Console.WriteLine();
                    Sauvegarde();
                    Menu();
                    break;

                case "3":
                    SuppresionLivre();
                    Console.WriteLine();
                    Menu();
                    break;

                case "4":
                    affichagebiblioAnee();
                    Console.WriteLine();
                    Menu();
                    break;

                case "5":
                    affichagebiblioPage();
                    Console.WriteLine();
                    Menu();
                    break;

                case "6":
                    ModLivre();
                    Console.WriteLine();
                    Menu();
                    break;

                case "7":
                    Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }
    }
}