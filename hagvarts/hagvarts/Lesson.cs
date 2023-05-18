using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Lesson
    {
        
        public string []hourtime = new string[20] ;
        public string []DayL = new string[20];
        public int numOfStudendsL;
        public int capacityL;
        public string offerSemesterL;
        public string []nameL = new string[20];
        private int _score;
        public Teacher teacher;
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                if (value < 10)
                    Console.WriteLine("you failed the lesson because you didn't get the enough score !");
            }
        }

    }
}
