using System.Collections.Generic;
using System.IO;
using System.Linq;
using Damme.Interfaces;

namespace Damme
{
    public class FileManager : IFile
    {
        /// <summary>
        /// Writes the data to a file
        /// </summary>
        /// <param name="field">Data to write</param>
        public void writeToFile(Pion[,] field)
        {
            List<Pion> filedToList = field.OfType<Pion>().ToList();

            string finalstr = "";
            for (int i = 0; i < filedToList.Count; i++)
            {
                finalstr += filedToList[i].PlayerSign;
            }

            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Play-Field.txt";
            System.IO.File.WriteAllText(dir, finalstr);
        }
    }
}