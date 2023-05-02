using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
//using (StreamReader file = new StreamReader("file.tsv"))

namespace hagvarts
{
    public class Program
    {

        static void Main(string[] args)
        {
            // writen by amin
            // khundan file
            using (StreamReader file = new StreamReader("file.tsv"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {

                    string[] Human = ln.Split('t').ToArray<string>();
                    human[] h = new human[Human.Length];
                    for (int j = 0; j / 8 < Human.Length; j++)
                    {
                        int i = 0;

                        h[i].name = Human[j];
                        i++;
                        h[i].family = Human[j];
                        i++;
                        h[i].dateOfBirth = Human[j];
                        i++;
                        h[i].gender = Human[j];
                        i++;
                        h[i].father = Human[j];
                        i++;
                        h[i].username = Human[j];
                        i++;
                        h[i].password = Human[j];
                        i++;
                        h[i].racetype = Human[j];
                        i++;
                        h[i].role = Human[j];

                    }

                }
                file.Close();
            }
            
            





        }
    }
}
