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
        public string floor;
        public string room;
        public string bed;
        public string gender;

        public Dorm(string a , string b, string c)
        {
            this.floor = a;
            this.room = b;
            this.bed = c;
        }
            
    }
}
