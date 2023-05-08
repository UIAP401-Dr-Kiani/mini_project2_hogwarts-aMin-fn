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
        public static void SendLetter(string name , string family , DateTime timeGo ,string cabinNum , string sitNum )
        {
            Console.WriteLine($"Hi {name} {family} . You are allowed to come to hagvarts. ");
            Console.WriteLine($"Your ticket is at : {timeGo} in the {cabinNum} cabin and {sitNum} sit");
            

        }
        
    }
}
