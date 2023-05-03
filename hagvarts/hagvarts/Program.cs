using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Program
    {


        static void Main(string[] args)
        {
            // writen by amin
            // khundan file
            int j = 0;
            string ln = File.ReadAllText("TXT_DATA.tsv");
            string[] humanNum = ln.Split('\n');


            string[] Human = ln.Split('\t', '\n').ToArray<string>();
            human[] h = new human[Human.Length + 10];





            for (int i = 0; i < humanNum.Length - 1; i++)
            {

                h[i] = new human();


                h[i].name = Human[j];
                j++;
                h[i].family = Human[j];
                j++;
                h[i].dateOfBirth = Human[j];
                j++;
                h[i].gender = Human[j];
                j++;
                h[i].father = Human[j];
                j++;
                h[i].username = Human[j];
                j++;
                h[i].password = Human[j];
                j++;
                h[i].racetype = Human[j];
                j++;
                h[i].role = Human[j];
                j++;

            }
            //fersadn letter be students

                for (int i = 0; i < 300; i++)
                {
                    if (h[i].role == "student")
                    {
                        Dambeldor.SendLetter(h[i].name, h[i].family, Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    }
                }
            
            Console.ReadKey();













        }

    }
}


