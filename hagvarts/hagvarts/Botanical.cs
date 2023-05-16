using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Botanical : Lesson
    {

        public static int TheListOfSemester1Plants(string a, string b, string c, string d)
        {
            
            string Plant1 = "Lavender";
            string Plant2 = "Garlic";
            string Plant3 = "Bamboo";
            String Plant4 = "Desert rose";
            int BotanicalScore = 0;
            if ((a == Plant1) || (a == Plant2) || (a == Plant3) || (a == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((b == Plant1) || (b == Plant2) || (b == Plant3) || (b == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((c == Plant1) || (c == Plant2) || (c == Plant3) || (c == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((d == Plant1) || (d == Plant2) || (d == Plant3) || (d == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            return BotanicalScore;
        }
        //public string TheListOfSemester1Plants { get; set; }
        //public string TheListOfSemester2Plants { get; set; }
        public static int TheListOfSemester2Plants(string a, string b, string c, string d)
        {

            string Plant1 = "Elderberry";
            string Plant2 = "Adenium obesum";
            string Plant3 = "Cucumber";
            String Plant4 = "Columbine";
            int BotanicalScore = 0;
            if ((a == Plant1) || (a == Plant2) || (a == Plant3) || (a == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((b == Plant1) || (b == Plant2) || (b == Plant3) || (b == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((c == Plant1) || (c == Plant2) || (c == Plant3) || (c == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((d == Plant1) || (d == Plant2) || (d == Plant3) || (d == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            return BotanicalScore;
        }
        public static int TheListOfSemester3Plants(string a, string b, string c, string d)
        {
            string Plant1 = "Ivy";
            string Plant2 = "Clover";
            string Plant3 = "English lavender";
            String Plant4 = "Cabbage";
            int BotanicalScore = 0;
            if ((a == Plant1) || (a == Plant2) || (a == Plant3) || (a == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((b == Plant1) || (b == Plant2) || (b == Plant3) || (b == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((c == Plant1) || (c == Plant2) || (c == Plant3) || (c == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((d == Plant1) || (d == Plant2) || (d == Plant3) || (d == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            return BotanicalScore;
        }
        public static int TheListOfSemester4Plants(string a, string b, string c, string d)
        {

            string Plant1 = "Daisy";
            string Plant2 = "Love-Lies-Bleeding";
            string Plant3 = "Neem Tree";
            string Plant4 = "rose";
            Student Plants = new Student();
            int BotanicalScore = 0;

            if ((a == Plant1) || (a == Plant2) || (a == Plant3) || (a == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((b == Plant1) || (b == Plant2) || (b == Plant3) || (b == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((c == Plant1) || (c == Plant2) || (c == Plant3) || (c == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }
            if ((d == Plant1) || (d == Plant2) || (d == Plant3) || (d == Plant4))
            {
                BotanicalScore = BotanicalScore + 5;
            }

            return BotanicalScore;

        }
        //public string TheListOfSemester3Plants { get; set; }
        //public string TheListOfSemester4Plants { get; set; }
    }
}
