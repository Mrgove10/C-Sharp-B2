using Damme.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Damme.Classes
{
    public class FileManager : IFile
    {
        /// <summary>
        /// Writes the data to a file
        /// </summary>
        /// <param name="field">Data to write</param>
        public void WriteToFile(Pion[,] field)
        {
            List<Pion> filedToList = field.OfType<Pion>().ToList();

            string finalstr = "";
            for (int i = 0; i < filedToList.Count; i++)
            {
                finalstr += filedToList[i].PlayerSign;
            }

            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfo != null)
            {
                string dir = directoryInfo.FullName + "\\Play-Field.txt";
                File.WriteAllText(dir, finalstr);
            }
        }
    }
}