using System;

namespace fizzbuzz
{
    internal class Program
    {
        public static int intmax = 25;

        public static int i = 0;

        private static void Main(string[] args)
        {
            try
            {
                #region Exo Principale

                /* while (i < intmax)
                  {
                      Console.WriteLine(i);
                      Console.WriteLine(isMultiple3(i));
                      Console.WriteLine(isMultiple5(i));
                      i++;
                      Console.WriteLine("------");
                  }
                  Console.ReadLine();*/

                #endregion Exo Principale

                #region Pour aller plus loin 1

                /* for (int j = 0; j < intmax; j++)
                 {
                     for (int i = 0; i < j; i++)
                     {
                         Console.Write(i);
                         Console.Write(isMultiple3(i));
                         Console.Write(isMultiple5(i));
                     }

                     Console.WriteLine();
                 }*/

                #endregion Pour aller plus loin 1

                #region Pour aller plus loin 2

                /*                for (int j = 0; j < 100; j++)
                                {
                                    for (int i = 0; i < j; i++)
                                    {
                                        if (i >= 71 && i <= 79)
                                        {
                                            if (i == 77)
                                            {
                                                Console.Write("Buzz-Buzz");
                                            }
                                            else
                                            {
                                                Console.Write("Buzz");
                                            }
                                        }
                                        else
                                        {
                                            Console.Write(i);
                                            Console.Write(isMultiple3(i));
                                            Console.Write(isMultiple5(i));
                                        }
                                    }

                                    Console.WriteLine();
                                }*/

                #endregion Pour aller plus loin 2

                #region Pour aller plus loin 3

                var valeuruser = 0;
                Console.WriteLine("Votre valeur : ");

                /*
                if (int.TryParse(valeuruser, ou))
                {
                    valeuruser = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ceci n'ets pas un chiffre");
                }
                */

                for (int j = 0; j < valeuruser; j++)
                {
                    for (int i = 0; i < j; i++)
                    {
                        if (i >= 71 && i <= 79)
                        {
                            if (i == 77)
                            {
                                Console.Write("Buzz-Buzz");
                            }
                            else
                            {
                                Console.Write("Buzz");
                            }
                        }
                        else
                        {
                            Console.Write(i);
                            Console.Write(isMultiple3(i));
                            Console.Write(isMultiple5(i));
                        }
                    }

                    Console.WriteLine();
                }

                #endregion Pour aller plus loin 3

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : \r " + ex);
                Console.ReadLine();
            }
        }

        public static string isMultiple3(int monchiffre)
        {
            if (monchiffre % 3 == 0)
            {
                return "Fizz";
            }

            return "";
        }

        public static string isMultiple5(int monchiffre)
        {
            Int32 lastNumber = monchiffre % 10;
            if (lastNumber == 5 || lastNumber == 0)
            {
                return "Buzz";
            }

            return "";
        }
    }
}