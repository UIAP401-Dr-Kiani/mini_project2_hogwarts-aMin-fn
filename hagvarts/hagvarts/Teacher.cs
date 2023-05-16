using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Teacher : AllowedPeople
    {
        private bool _simultaneousTeaching;
        public bool simultaneousTeaching { get; set; }
        public string Lesson1 { get; set; }
        public string Lesson2 { get; set; }
        public string TimeClass1 { get; set; }
        public string TimeClass2 { get; set;}

        //public string ExerciseBotanical1(string a ,string b, string c , string d)
        //{
        //    Botanical.TheListOfSemester1Plants();
           
        //        return "j";
        //}
    }
}
