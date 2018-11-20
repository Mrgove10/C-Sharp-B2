namespace Exercice_9_1.Dll
{
    /// <summary>
    /// Enumeration des posibilité
    /// </summary>
    public enum ChiFouMi
    {
        Pierre = 0,
        Feuille = 1,
        Ciseaux = 2,
        Puit = 3
    }

    /// <summary>
    /// interface ChiFouMiObjects
    /// </summary>
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

    /// <summary>
    /// classe pierre
    /// </summary>
    public class Pierre : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Pierre; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Ciseaux;
        }
    }

    /// <summary>
    /// classe Feuille
    /// </summary>
    public class Feuille : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Feuille; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Pierre || value == ChiFouMi.Puit;
        }
    }

    /// <summary>
    /// classe ciseaux
    /// </summary>
    public class Ciseaux : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Ciseaux; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Feuille;
        }
    }

    /// <summary>
    /// classe puit
    /// </summary>
    public class Puit : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Puit; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Pierre || value == ChiFouMi.Ciseaux;
        }
    }
}