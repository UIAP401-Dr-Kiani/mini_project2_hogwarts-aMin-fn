using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public enum Pet
    {
        rat,
        cat,
        owl,
        
    };
    public enum Role
    {
        teacher,
        student,
    };
    public class AllowedPeople:human
    {
        public string Curriculum;
        public Pet pet;
        public string Group;
        public bool Luggage;
        public Role role;
       
        //public string timeGo;
        //public string cabinNum;
        //public string sitNum;

    }
}
