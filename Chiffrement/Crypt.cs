using System;
using System.Collections.Generic;
using System.Linq;

namespace Chiffrement
{
    internal class Crypt
    {
        private static string Alpha = "abcdefghijklmnopqrstuvwxyz";
        private List<char> Alphalist = Alpha.ToList();

        public void init()
        {
            Console.WriteLine("Chyfrage de cesar");
            Console.WriteLine("chaine a chyfre");
            string str = Console.ReadLine();
            Console.WriteLine("decalage");
            int deca = Int32.Parse(Console.ReadLine());
            // string c = Cesar(str, deca);
            // Console.WriteLine(c);
            // string cd = Decrypt(c, deca);
            // Console.WriteLine(cd);
            // var i = Substitution(Console.ReadLine(), Console.ReadLine());
            // ZConsole.WriteLine(i);

            Console.ReadLine();
        }
    }
}