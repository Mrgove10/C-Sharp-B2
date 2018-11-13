using System.Collections.Generic;
using System.Linq;

namespace mastermind
{
    internal class Verification
    {
        /// <summary>
        /// Verifie la chaine de pio donner avec la prediction de la machine
        /// </summary>
        /// <param name="Tour"></param>
        /// <param name="predic"></param>
        public void verifTest(Tour Tour, Prediction predic)
        {
            int i = 0;
            List<Pion> MainPrediction = predic.GetPrediction();
            foreach (var pion in Tour.PionsTour)
            {
                if (MainPrediction[i].ColorPion == pion.ColorPion)//bon endroit et bonne couleur dans  la chaine.
                {
                    Tour.Verif.Add(new Pion("Blanc"));
                }
                else if (MainPrediction.Any(x => x.ColorPion == pion.ColorPion)) //au moin a un endroid dans la ligne
                {
                    Tour.Verif.Add(new Pion("Rouge"));
                }
                else //dans les autre cas
                {
                    Tour.Verif.Add(new Pion("Noir"));
                }

                i++;
            }
        }

        /// <summary>
        /// Verifie si touts les pions sont au bonne endroit, signifiant la victoire
        /// </summary>
        /// <param name="t"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsAllGood(Tour t, Prediction p)
        {
            if (t.PionsTour[0].ColorPion == p.GetPrediction()[0].ColorPion &&
                t.PionsTour[1].ColorPion == p.GetPrediction()[2].ColorPion &&
                t.PionsTour[2].ColorPion == p.GetPrediction()[2].ColorPion &&
                t.PionsTour[3].ColorPion == p.GetPrediction()[3].ColorPion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}