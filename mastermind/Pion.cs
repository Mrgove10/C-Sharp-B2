namespace mastermind
{
    public class Pion
    {
        public Color ColorPion; //couleur du pion

        public enum Color // liste des couleurs possible
        {
            Rouge,
            Vert,
            Bleu,
            Jaune,
            Blanc,
            Noir
        }

        /// <summary>
        /// Cree un pion d'une couleur particuliere
        /// </summary>
        /// <param name="Color_P"></param>
        public Pion(int IntColor)
        {
            ColorPion = (Color)IntColor;
        }

        /// <summary>
        /// Cree un pion en fonction d'un string de couleur
        /// </summary>
        /// <param name="StringColor"></param>
        public Pion(string StringColorinput)
        {
            string StringColor = StringColorinput.ToLower();
            if (StringColor == "rouge")
            {
                ColorPion = Color.Rouge;
            }
            if (StringColor == "vert")
            {
                ColorPion = Color.Vert;
            }
            if (StringColor == "bleu")
            {
                ColorPion = Color.Bleu;
            }
            if (StringColor == "jaune")
            {
                ColorPion = Color.Jaune;
            }
            if (StringColor == "blanc")
            {
                ColorPion = Color.Blanc;
            }
            if (StringColor == "noir")
            {
                ColorPion = Color.Noir;
            }
        }
    }
}