namespace Exercice_9_1.Dll
{
    public class Game
    {
        private IConsole console;
        private IRandom random;

        /// <summary>
        /// Constructeur de Game
        /// </summary>
        /// <param name="console"></param>
        /// <param name="random"></param>
        public Game(IConsole console, IRandom random)
        {
            this.console = console;
            this.random = random;
        }

        /// <summary>
        /// Fonction Principale de depart du jeu
        /// </summary>
        public void Start()
        {
            while (true)
            {
                ChiFouMi valeurJoueur = RecupererValeurJoueur();
                ChiFouMiObject valeurApplication = RecupererValeurApplication();
                TestGagant(valeurJoueur, valeurApplication);
            }
        }

        /// <summary>
        /// test du gagatnt de la manche
        /// </summary>
        /// <param name="valeurJoueur"></param>
        /// <param name="valeurApplication"></param>
        /// <returns></returns>
        public string TestGagant(ChiFouMi valeurJoueur, ChiFouMiObject valeurApplication)
        {
            if (valeurJoueur == valeurApplication.Value)
            {
                console.WriteLine("Egalité.");
                return "Ega";
            }
            else if (valeurApplication.Bat(valeurJoueur))
            {
                console.WriteLine("L'ordinateur a gagné, il a joué : " + valeurApplication.Value.ToString());
                return "Ordi";
            }
            else
            {
                console.WriteLine("Bravo, vous avez gagné, il a joué : " + valeurApplication.Value.ToString());
                return "Joueur";
            }
        }

        /// <summary>
        /// Recuperela valeur du joueur via la console
        /// </summary>
        /// <returns></returns>
        public ChiFouMi RecupererValeurJoueur()
        {
            //TODO : to lower & test
            console.WriteLine("Tapez 0 pour la pierre, 1 pour la feuille, 2 pour les ciseaux et 3 pour le puit.");
            int valeur = int.Parse(console.ReadLine());
            return (ChiFouMi)valeur;
        }

        /// <summary>
        /// Genere aleatoirement une valeur pour le bot
        /// </summary>
        /// <returns></returns>
        public ChiFouMiObject RecupererValeurApplication()
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

        /// <summary>
        /// Cree un objet chifoumi
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private ChiFouMiObject CreateChiFouMiObject<T>() where T : ChiFouMiObject, new()
        {
            return new T();
        }
    }
}