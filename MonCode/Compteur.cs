using System.Linq;

namespace MonCode
{
    /// <summary>
    /// Compteur D'element
    /// </summary>
    public class Compteur
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="console"></param>
        public Compteur(IConsole console)
        {
            this.console = console;
        }

        private IConsole console;

        /// <summary>
        /// Valeur du text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Compte le nombre de a dans une chaine
        /// </summary>
        /// <param name="texte"></param>
        /// <returns></returns>
        public int CompteNombreA()
        {
            if (Text != null)
            {
                Text = Text.ToLower();
                return Text.Count(e => e == 'a');
            }
            else
            {
                return 0;
            }
        }
    }
}