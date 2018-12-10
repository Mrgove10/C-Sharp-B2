using System;

namespace Damme
{
    public class ValidationEngine : IValidation
    {
        /// <summary>
        /// Validates if a pion can be changed to that place
        /// </summary>
        /// <param name="pionToMove"></param>
        /// <param name="xTo"></param>
        /// <param name="yTo"></param>
        /// <param name="mainField"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool Validate(Pion pionToMove, int xTo, int yTo, Pion[,] mainField, char player)
        {
            //TODO: only workd when 0,0 is in the botom left
            if (pionToMove.X != xTo && pionToMove.Y != yTo)
            {
                var longeur = Math.Sqrt(Math.Pow(xTo - pionToMove.X, 2) + Math.Pow(yTo - pionToMove.Y, 2));
                if (longeur == 1)
                {
                    if (mainField[xTo, yTo].PlayerSign == ' ')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (longeur > 2)
                {
                    Pion pToGo = mainField[xTo, yTo];
                    //
                }
            }
            return false;
        }
    }
}