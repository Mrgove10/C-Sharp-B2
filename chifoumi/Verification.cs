namespace chifoumi
{
    internal class Verification
    {
        /// <summary>
        /// Verifie les coup et resort le joueur victorieux
        /// </summary>
        /// <param name="Coup1"></param>
        /// <param name="J1"></param>
        /// <param name="Coup2"></param>
        /// <param name="J2"></param>
        /// <returns>Joueur gagant</returns>
        public Joueur verif(Etape.posibilite Coup1, Joueur J1, Etape.posibilite Coup2, Joueur J2)
        {
            #region Pierre

            if (Coup1 == Etape.posibilite.Pierre && Coup2 == Etape.posibilite.Pierre)
            {
                return null;
            }

            if (Coup1 == Etape.posibilite.Pierre && Coup2 == Etape.posibilite.Feuille)
            {
                return J2;
            }

            if (Coup1 == Etape.posibilite.Pierre && Coup2 == Etape.posibilite.Ciseaux)
            {
                return J1;
            }

            if (Coup1 == Etape.posibilite.Pierre && Coup2 == Etape.posibilite.Puit)
            {
                return J2;
            }

            #endregion Pierre

            #region Feuille

            if (Coup1 == Etape.posibilite.Feuille && Coup2 == Etape.posibilite.Pierre)
            {
                return J1;
            }

            if (Coup1 == Etape.posibilite.Feuille && Coup2 == Etape.posibilite.Feuille)
            {
                return null;
            }

            if (Coup1 == Etape.posibilite.Feuille && Coup2 == Etape.posibilite.Ciseaux)
            {
                return J2;
            }

            if (Coup1 == Etape.posibilite.Feuille && Coup2 == Etape.posibilite.Puit)
            {
                return J1;
            }

            #endregion Feuille

            #region Ciseau

            if (Coup1 == Etape.posibilite.Ciseaux && Coup2 == Etape.posibilite.Pierre)
            {
                return J2;
            }

            if (Coup1 == Etape.posibilite.Ciseaux && Coup2 == Etape.posibilite.Feuille)
            {
                return J1;
            }

            if (Coup1 == Etape.posibilite.Ciseaux && Coup2 == Etape.posibilite.Ciseaux)
            {
                return null;
            }

            if (Coup1 == Etape.posibilite.Ciseaux && Coup2 == Etape.posibilite.Puit)
            {
                return J2;
            }

            #endregion Ciseau

            #region Puit

            if (Coup1 == Etape.posibilite.Puit && Coup2 == Etape.posibilite.Pierre)
            {
                return J1;
            }

            if (Coup1 == Etape.posibilite.Puit && Coup2 == Etape.posibilite.Feuille)
            {
                return J2;
            }

            if (Coup1 == Etape.posibilite.Puit && Coup2 == Etape.posibilite.Ciseaux)
            {
                return J1;
            }

            if (Coup1 == Etape.posibilite.Puit && Coup2 == Etape.posibilite.Puit)
            {
                return null;
            }

            #endregion Puit

            #region Egalité

            if (Coup1 == Coup2) //en cas d'egalité, retour d'aucun vainquer
            {
                return null;
            }

            #endregion Egalité

            return null;
        }
    }
}