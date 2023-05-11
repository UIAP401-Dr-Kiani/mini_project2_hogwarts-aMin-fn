using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Dorm
    {
        public enum type
        {
            Hufflepuff = 1,
            Gryffindor = 2,
            Ravenclaw = 3,
            Slytherin = 4
        };
        public int floor;
        public int room;
        public int bed;
        public string gender;

        public Dorm(int a, int b, int c)
        {
            this.bed = a;
            this.room = b;
            this.floor = c;
        }

    }
}
