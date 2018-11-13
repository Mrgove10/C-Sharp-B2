using System;

namespace wheeeee
{
    public class tortue
    {
        public de rd = new de();

        public string id;

        public int bonus;

        public tortue()
        {
            id = Guid.NewGuid().ToString();
            bonus = rd.lancee(4);
        }
    }
}