using System;

namespace wheeeee
{
    public class de
    {
        private Random rand = new Random();

        public int lancee(int max)
        {
            return rand.Next(1, max);
        }
    }
}