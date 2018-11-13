namespace chifoumi
{
    internal class Joueur
    {
        public enum type //type de joueur possible
        {
            Reel,
            Bot,
            BotAI
        }

        public string nom; //nom du joueur
        public type typePlayer; //type du joueur

        /// <summary>
        /// Construteur du joueur
        /// </summary>
        /// <param name="nomP"></param>
        /// <param name="typePlayerP"></param>
        public Joueur(string nomP, type typePlayerP)
        {
            nom = nomP;
            typePlayer = typePlayerP;
        }
    }
}