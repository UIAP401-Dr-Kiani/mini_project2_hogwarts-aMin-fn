﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class AllowedPeople:human
    {
        public string Curriculum;
        public enum Pet
        {
            rat =1,
            cat =2,
            owl =3,
        };
        public string Group;
        public bool Luggage;
        public enum Role
        {
            teacher =1,
            student =2,
        };
        //public string[] Letter = new string[100]; 
        //public List<string> LetterList = new List<string>();

    }
}