namespace Exercice_9_1
{
    public enum ChiFouMi
    {
        Pierre = 0,
        Feuille = 1,
        Ciseaux = 2,
        Puit = 3
    }

    public interface ChiFouMiObject
    {
        ChiFouMi Value { get; }

        /// <summary>
        /// Renvoie vrai si l'objet courant bat la valeur passée en paramètre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Bat(ChiFouMi value);
    }

    public class Pierre : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Pierre; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Ciseaux;
        }
    }

    public class Feuille : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Feuille; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Pierre || value == ChiFouMi.Puit;
        }
    }

    public class Ciseaux : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Ciseaux; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Feuille;
        }
    }

    public class Puit : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Puit; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Pierre || value == ChiFouMi.Ciseaux;
        }
    }
}