using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public enum Type
    {
        Hufflepuff = 1,
        Gryffindor = 2,
        Ravenclaw = 3,
        Slytherin = 4
    };
    public class Group
    {
        public Type type;
        public int score;
        public string listOfpeopleInGp;
        public string listOfQPlayers;
    }
}
