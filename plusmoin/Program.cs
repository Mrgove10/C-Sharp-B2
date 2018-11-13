using System;

namespace plusmoin
{
    internal class Program
    {
        public static int guess;
        public static string read = "0";
        public static int readint;
        public static int nbdetest;

        public static int genmanchine;

        private static void Main(string[] args)
        {
            try
            {
                #region part1

                /*  nbdetest = 15;

                  Random rnd = new Random();
                  guess = rnd.Next(0, 1001);
               //   Console.WriteLine("debug value : " + guess);

                  while (readint != guess)
                  {
                      if (nbdetest > 0)
                      {
                          nbdetest = nbdetest - 1;
                          Console.WriteLine("plus que " + nbdetest + " essaies");

                          Console.WriteLine("Choissir un chiffre :");
                          read = Console.ReadLine();
                          readint = Int32.Parse(read);
                          if (readint == guess)
                          {
                              Console.WriteLine("victoire");
                              Console.ReadLine();
                              break;
                          }
                          else
                          {
                              if (readint - guess < 0)
                              {
                                  Console.WriteLine("c'est plus ");
                              }

                              if (readint - guess > 0)
                              {
                                  Console.WriteLine("c'est moins ");
                              }
                          }
                      }
                      else
                      {
                          Console.WriteLine("perdu");
                          break;
                      }
                  }*/

                #endregion part1

                #region part2

                Random rnd = new Random();
                Console.WriteLine("votre nombre entre 0 et 1000");

                int min = 0;
                int max = 1001;
                while (true)
                {
                    genmanchine = rnd.Next(min, max);
                    Console.WriteLine("nombre tester : " + genmanchine);
                    Console.WriteLine("+ OU - OU t " + genmanchine);
                    var tmpsigne = "";
                    tmpsigne = Console.ReadLine();

                    if (tmpsigne != "t")
                    {
                        if (tmpsigne == "+")
                        {
                            min = genmanchine;
                        }
                        else if (tmpsigne == "-")
                        {
                            max = genmanchine;
                        }
                    }
                    else
                    {
                        Console.WriteLine("la machine a trouver votre nombre, c'est :  " + genmanchine);
                        break;
                    }
                }
                Console.ReadLine();

                #endregion part2
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);

                Console.ReadLine();
            }
        }
    }
}