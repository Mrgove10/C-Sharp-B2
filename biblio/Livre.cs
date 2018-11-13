using System;

namespace biblio
{
    public class Livre
    {
        public string id { get; set; }
        public string titre { get; set; }
        public int datePublication { get; set; }
        public int NbdePage { get; set; }

        public Livre()
        {
        }

        public Livre(string titre, int datePublication, int nbdePage)
        {
            this.id = Guid.NewGuid().ToString();
            this.titre = titre;
            this.datePublication = datePublication;
            NbdePage = nbdePage;
        }
    }
}