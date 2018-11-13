namespace mastermind
{
    public interface IPion
    {
        string ColorPionString { get; set; }

        Pion.Color ColorPion { get; set; }
    }

    public class Pioni : IPion
    {
        public string ColorPionString { get; set; }
        public Pion.Color ColorPion { get; set; }
        public Pioni(string colorP)
        {
            ColorPionString = colorP.ToLower();

            if (colorP == "rouge")
            {
                ColorPion = Pion.Color.Rouge;
            }
            if (colorP == "vert")
            {
                ColorPion = Pion.Color.Vert;
            }
            if (colorP == "bleu")
            {
                ColorPion = Pion.Color.Bleu;
            }
            if (colorP == "jaune")
            {
                ColorPion = Pion.Color.Jaune;
            }
            if (colorP == "blanc")
            {
                ColorPion = Pion.Color.Blanc;
            }
            if (colorP == "noir")
            {
                ColorPion = Pion.Color.Noir;
            }
        }
    }

    public class PionJaune : Pioni
    {
        public PionJaune(string col) : base("Jaune")
        {
        }
    }

    public class PionVert : Pioni
    {
        public PionVert(string col) : base("Vert")
        {
        }
    }

    public class PionBleu : Pioni
    {
        public PionBleu(string col) : base("Bleu")
        {
        }
    }

    public class PionRouge : Pioni
    {
        public PionRouge(string col) : base("Rouge")
        {
        }
    }

    public class PionBlanc : Pioni
    {
        public PionBlanc(string col) : base("Blanc")
        {
        }
    }

    public class PionNoir : Pioni
    {
        public PionNoir(string col) : base("Noir")
        {
        }
    }
}