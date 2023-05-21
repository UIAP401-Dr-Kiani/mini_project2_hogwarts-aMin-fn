using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Massages : human
    {
        public static void loading()
        {
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            string load = "Loading...";
            for (int i = 0; i < load.Length; i++)
            {
                Console.Write(load[i]);
                Thread.Sleep(200);
                
            }
            Console.WriteLine();
        }
        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                           ");
            Console.WriteLine($"                Hargvarts              {DateTime.Now.ToShortTimeString()} ");
            Console.WriteLine("---------------------------------------------------------------------------");
        }
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
            Console.WriteLine("1.information(i)                      2.passedUnits(p)           3.dormNumber(d)                     4.letters(l)");
            Console.WriteLine("5.send letter to Dambeldor(sd)        6.Practice(pr)             7.score of botanical(ScoreB)        8.LessonLog(log)      ");

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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.send letter(s)     2.list of dorm(l)       3.inbox(i)");
            Console.ResetColor();
            
           
        }
        public static void teacherChoise()
        {
            Console.WriteLine("1.information(i)     2.Lesson presentation(p)       3.students' score(s)       4.Groups(g)");
        }
        public static void showUnits()
        {

            Console.WriteLine("units : ");
            Console.WriteLine("Sport2       Math2       Physics2        Chemistry       Occultism       ");
            Console.WriteLine("you should choose them :");
        }
        public static void logSemester1(Student[] student, int temp)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"botanical : {student[temp].ScoreSemester1}");
            Console.WriteLine($"Math1 : {student[temp].Math1Score}");
            Console.WriteLine($"Physics1 : {student[temp].Physics1Score}");
            Console.WriteLine($"Sport1 : {student[temp].Sport1Score}");
            Console.WriteLine($"Literature : {student[temp].LiteratureScore}");
            Console.ResetColor();
            
            
            
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
