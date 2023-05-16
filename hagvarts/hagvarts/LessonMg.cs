using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class LessonMg
    {

       
        public static  string randomtime()
        {
            Random randomdayofweek = new Random();
            var list2 = new List<string> { "satarday", "sunday", "monday", "tuesday", "thursday" };
            int startTime = new Random().Next(8, 14);
            int endTime = startTime + 2;

            return $"{list2[new Random().Next(list2.Count)]} {startTime} : {endTime}";

        }
        public static List<Lesson> Term1Lessons()
        {

                
            List<Lesson> term1lessons = new List<Lesson>();
            Botanical b = new Botanical();
            b.capacityL = 20;
            b.timeL =  randomtime();
            b.nameL = "Botanical";
            b.offerSemesterL = "1";

            term1lessons.Add(b);


            Math math = new Math();
            math.timeL = randomtime();
            math.nameL = "math";
            math.capacityL = 20;
            math.offerSemesterL = "1";

            
            term1lessons.Add(math);
            Sport sport = new Sport();
            sport.capacityL = 20;
            sport.timeL = randomtime();
            sport.nameL = "sprot";
            sport.offerSemesterL = "1";
            term1lessons.Add(sport);

            Chemistry chemistry = new Chemistry();
            chemistry.timeL = randomtime();
            chemistry.capacityL = 20;
            chemistry.nameL = "chemistry";
            chemistry.offerSemesterL = "1";

            term1lessons.Add(chemistry);

            return term1lessons;
        }
    }
}
