using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Dambeldor:AllowedPeople
    {
        public static void SendLetter(string name , string family , DateTime timeGo ,int cabinNum , int sitNum )
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($" {name} {family}  ");
            Console.WriteLine($" Your ticket is at : {timeGo} in the {cabinNum} cabin and {sitNum} sit");
            Console.ResetColor();
            

        }
        public string  Inbox{ get; set; }
        public static void recLetters(string letter )
        {
            int i = 0;
            string[] letters = new string[100];
            //string aimstuName = name;
            //string aimstuFamily = family;

            letters[i] = letter;
            i++;

            
            


        }

    }
}
