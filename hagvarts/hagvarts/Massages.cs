using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Massages:human
    {
        public static void choise()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("choose one :     1.studend(s)        2.teacher(t)        3.dambeldor(d)");
            //Thread.Sleep(750);
            //Console.WriteLine("1.studend(s)");
            //Thread.Sleep(750);
            //Console.WriteLine("2.teacher(t)");
            //Thread.Sleep(750);
            //Console.WriteLine("3.dambeldor(d)");
            Console.ResetColor();
        }
        public static void studentChoise()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.information(i)     2.passedUnits(p)       3.semester(s)       4.dormNumber(d)      5.letters(l)       6.send letter to Dambeldor");

            Thread.Sleep(750);
            //Thread.Sleep(750);
            //Console.WriteLine("3.semester(s)");
            //Thread.Sleep(750);
            //Console.WriteLine("4.dormNumber(d)");
            //Thread.Sleep(750);
            //Console.WriteLine("5.letters(l)");
            Console.ResetColor();
        }
        public static void dambeldorChoise()
        {
            Console.WriteLine("1.send letter(s)");
            Console.WriteLine("2.list of dorm(l)");
            Console.WriteLine("3.inbox(i)");
        }
       public static void teacherChoise()
        {
            Console.WriteLine("1.information(i)     2.Lesson presentation       3.students' score");
        }
    }
}
