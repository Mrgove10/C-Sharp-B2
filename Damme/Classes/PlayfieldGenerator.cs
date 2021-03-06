﻿using Damme.Classes;

namespace Damme
{
    public class PlayfieldGenerator
    {
        /// <summary>
        /// Generates a playing Field
        /// </summary>
        /// <param name="size">Size of the playing field</param>
        /// <returns>Complete playing field</returns>
        public Pion[,] GeneratePlayField(int size)
        {
            Pion[,] field = new Pion[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    field[x, y] = new Pion(x, y, ' ');
                }
            }

            for (int x = 0; x < size; x++) //colones
            {
                if (x == 0 || x == 2)
                {
                    for (int y = 0; y < 10; y = y + 2) //white= 0
                    {
                        field[x, y] = new Pion(x, y, '0');
                    }
                }
                if (x == 1 || x == 3)
                {
                    for (int y = 1; y < 10; y = y + 2) //white = 0
                    {
                        field[x, y] = new Pion(x, y, '0');
                    }
                }

                if (x == 6 || x == 8)
                {
                    for (int y = 0; y < 10; y = y + 2) //black = 1
                    {
                        field[x, y] = new Pion(x, y, '1');
                    }
                }
                if (x == 7 || x == 9)
                {
                    for (int y = 1; y < 10; y = y + 2) //black = 1
                    {
                        field[x, y] = new Pion(x, y, '1');
                    }
                }
            }

            string l = "";
            foreach (var p in field)
            {
                l = l + p.PlayerSign;
            }

            FileManager FM = new FileManager();
            FM.WriteToFile(field);

            return field;
        }
    }
}