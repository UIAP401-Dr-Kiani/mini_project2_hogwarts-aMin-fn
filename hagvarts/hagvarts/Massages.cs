using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Massages:human
    {
        public static void choise()
        {
            Console.WriteLine("choose one :");
            Console.WriteLine("1.studend(s)");
            Console.WriteLine("2.teacher(t)");
            Console.WriteLine("3.dambeldor(d)");
        }
        public static void studentChoise()
        {
            Console.WriteLine("1.information(i)");
            Console.WriteLine("2.passedUnits(p)");
            Console.WriteLine("3.semester(s)");
            Console.WriteLine("4.dormNumber(d)");
        }
        
       
    }
}
