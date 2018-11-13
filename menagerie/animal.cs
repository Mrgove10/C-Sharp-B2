namespace menagerie
{
    /// <summary>
    /// interface de l'animal
    /// </summary>
    public interface IAnimal
    {
        string Nom { get; set; }
        int NombrePattes { get; set; }
        string Cri { get; set; }
        int PositionCourse { get; set; }
    }

    public class Animal : IAnimal
    {
        public string Nom { get; set; }
        public int NombrePattes { get; set; }
        public string Cri { get; set; }
        public int PositionCourse { get; set; }

        public Animal(string nom, string cri, int nbpattes)
        {
            Nom = nom;
            NombrePattes = nbpattes;
            Cri = cri;
        }
    }

    public class Poussin : Animal
    {
        public Poussin(string nom) : base(nom, "Piou Piou", 2)
        {
        }
    }

    public class Chat : Animal
    {
        public Chat(string nom) : base(nom, "Miaou Miaou", 4)
        {
        }
    }

    public class Chien : Animal
    {
        public Chien(string nom) : base(nom, "Wouaf Wouaf", 4)
        {
        }
    }

    public class Vache : Animal
    {
        public Vache(string nom) : base(nom, "Meuh Meuh", 4)
        {
        }
    }

    public class Taureau : Animal
    {
        public Taureau(string nom) : base(nom, "Mow Mow", 4)
        {
        }
    }

    public class Dindon : Animal
    {
        public Dindon(string nom) : base(nom, "Glou Glou", 2)
        {
        }
    }
}