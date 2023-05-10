using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public enum Racetype
    {
        Half_blood,
        Pure_blood,
        Muggle_blood
    };
    public class human
    {
        public string name;
        public string family;
        public string dateOfBirth;
        public string gender;
        public string father;
        public string username;
        public string password;
        
        public Racetype racetype;
        //public string racetype;
        public string role;
        public DateTime timeGo;
        public int cabinNum;
        public int sitNum;


    }
}
