using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int i = 0;
            int j = 0;
            int temp = 0;
            string ln = File.ReadAllText("TXT_DATA.tsv");
            string[] humanNum = ln.Split('\n');


            string[] Human = ln.Split('\t', '\n').ToArray<string>();
            AllowedPeople[] h = new AllowedPeople[Human.Length + 10];
            if ("gender" == "female")
                h[0].pet = Pet.cat;
            //switch (h[0].pet)
            //{
            //    case Pet.cat:
            //        break;
            //    case Pet.rat:
            //        break;
            //}


            for (i = 0; i < humanNum.Length - 1; i++)
            {

                h[i] = new AllowedPeople();


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
                //h[i].racetype = Human[j];
                switch (Human[j])
                {
                    case "Pure blood":
                        h[i].racetype = Racetype.Pure_blood;
                        break;
                    case "Half blood":
                        h[i].racetype = Racetype.Half_blood;
                        break;
                    case "Muggle blood":
                        h[i].racetype = Racetype.Muggle_blood;
                        break;
                }
                j++;
                h[i].role = Human[j];
                j++;

            }

            int studentNum = 0;
            int teacherNum = 0;
            for (i = 0; i < 300; i++)
            {
                if (h[i].role == "student\r")
                {
                    studentNum++;
                }
                else
                    teacherNum++;
            }


            //fersadn letter be students
            //for (i = 0; i < 300; i++)
            //{
            //    j = 0;
            //    stu[j] = new Student();
            //    if (h[i].role == "student\r")
            //    {
            //        stu[j].name = h[i].name;
            //        stu[j].family= h[i].family;
            //        stu[j].gender = h[i].gender;
            //        stu[j].role = h[i].role;
            //        h[j].username = h[i].username;
            //        h[j].password = h[i].password;
            //        h[j].racetype = h[i].racetype;
            //        h[j].father = h[i].father;
            //        h[j].dateOfBirth = h[i].dateOfBirth;

            //        j++;
            //    }

            //}
            Student[] stu = new Student[studentNum];

            //for (i = 0; i < 300; i++)
            //{
            //    stu[i] = new Student(h[i].name, h[i].family, h[i].timeGo, h[i].cabinNum, h[i].sitNum);
            //    if (h[i].role == "student\r")
            //    {
            //        Console.WriteLine("write time to go and number of cabin and seat in order : ");
            //        h[i].timeGo = Console.ReadLine();
            //        h[i].cabinNum = Console.ReadLine();
            //        h[i].sitNum = Console.ReadLine();
            //        Dambeldor.SendLetter(h[i].name, h[i].family, h[i].timeGo, h[i].cabinNum, h[i].sitNum);

            //    }


            //}

            while (true)
            {


                Massages.choise();
                string Choise = Console.ReadLine();

                switch (Choise)
                {
                    case "s":
                        {
                            Console.WriteLine("enter your name and family : ");
                            bool allow = false;

                            string aimName = Console.ReadLine();
                            string aimFamily = Console.ReadLine();
                            for (i = 0; i < h.Length; i++)
                            {
                                if (h[i].name == aimName && h[i].family == aimFamily)
                                {
                                    allow = true;
                                    temp = i;
                                }
                            }
                            if (allow)
                            {
                                Massages.studentChoise();
                                string stuChoise = Console.ReadLine();
                                switch (stuChoise)
                                {
                                    case "i":

                                        if (h[temp].role == "student\r")
                                        {
                                            Console.WriteLine($"name : {h[temp].name}");
                                            Console.WriteLine($"family : {h[temp].family}");
                                            Console.WriteLine($"dateOfBirth : {h[temp].dateOfBirth}");
                                            Console.WriteLine($"gender : {h[temp].gender}");
                                            Console.WriteLine($"father : {h[temp].father}");
                                            Console.WriteLine($"username : {h[temp].username}");
                                            Console.WriteLine($"password : {h[temp].password}");
                                            Console.WriteLine($"raceType : {h[temp].racetype}");
                                            Console.WriteLine($"role : {h[temp].role}");
                                            Console.WriteLine($"group : {h[temp].Group}");
                                            Console.WriteLine($"haveing luggage : {h[temp].Luggage}");
                                            Console.WriteLine("last letter : ");
                                            Dambeldor.SendLetter(h[temp].name, h[temp].family, h[temp].timeGo, h[temp].cabinNum, h[temp].sitNum);
                                            Console.WriteLine($"pet : {h[temp].pet}");
                                        }
                                        break;


                                    case "p":

                                        break;

                                    case "s":

                                        break;


                                    case "d":

                                        break;


                                    default:
                                        break;
                                }
                            }

                            break;
                        }
                    case "t":
                        {

                            break;
                        }
                    case "d":
                        {
                            Massages.dambeldorChoise();
                            string dambeldorChoose = Console.ReadLine();
                            switch (dambeldorChoose)
                            {
                                
                                case "s":
                                    {
                                        //for (i = 0; i < 300; i++)
                                        //{
                                        Console.WriteLine("write the people number");
                                        int q = int.Parse(Console.ReadLine());

                                        stu[q - 1] = new Student(h[q - 1].name, h[q - 1].family, h[q].timeGo, h[q - 1].cabinNum, h[q - 1].sitNum);
                                        if (h[q - 1].role == "student\r")
                                        {
                                            Console.WriteLine("write time to go and number of cabin and seat in order : ");


                                            Random random = new Random();
                                            DateTime[] myDateTime = new DateTime[100];

                                            myDateTime[q-1] = new DateTime(2023, 1, random.Next(1, 31), random.Next(0, 24), random.Next(0, 60), 0);
                                            h[q - 1].timeGo = myDateTime[q-1];
                                            h[q - 1].cabinNum = Console.ReadLine();
                                            h[q - 1].sitNum = Console.ReadLine();
                                            Dambeldor.SendLetter(h[q - 1].name, h[q - 1].family, h[q - 1].timeGo, h[q - 1].cabinNum, h[q - 1].sitNum);

                                        }

                                        //}
                                        break;
                                    }
                                case "l":
                                    {
                                        break;
                                    }
                            }
                            break;
                        }

                    default:
                        break;
                }
            }






















            Console.ReadKey();













        }

    }
}


