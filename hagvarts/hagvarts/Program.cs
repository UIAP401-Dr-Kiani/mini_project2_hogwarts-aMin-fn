using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

                if (Human[j] == "student\r")
                    h[i].role = Role.student;
                else h[i].role = Role.teacher;
                j++;



            }



            int studentNum = 0;
            int teacherNum = 0;
            for (i = 0; i < 300; i++)
            {
                if (h[i].role == Role.student)
                {
                    studentNum++;
                }
                else
                    teacherNum++;
            }

            int StuCounter = 0;
            Student[] s = new Student[studentNum];
            for (i = 0; i < 300; i++)
            {
                if (h[i].role == Role.student)
                {

                    s[StuCounter] = new Student();
                    s[StuCounter].name = h[i].name;
                    s[StuCounter].family = h[i].family;
                    s[StuCounter].timeGo = h[i].timeGo;
                    s[StuCounter].cabinNum = h[i].cabinNum;
                    s[StuCounter].sitNum = h[i].sitNum;
                    s[StuCounter].father = h[i].father;
                    s[StuCounter].username = h[i].username;
                    s[StuCounter].password = h[i].password;
                    s[StuCounter].dateOfBirth = h[i].dateOfBirth;
                    s[StuCounter].gender = h[i].gender;
                    s[StuCounter].pet = h[i].pet;

                    StuCounter++;

                }
            }
            int TchCounter = 0;
            Teacher[] t = new Teacher[teacherNum];
            Random r3 = new Random();
            for (i = 0; i < 300; i++)
            {
                if (h[i].role == Role.teacher)
                {

                    t[TchCounter] = new Teacher();
                    t[TchCounter].name = h[i].name;
                    t[TchCounter].family = h[i].family;
                    t[TchCounter].father= h[i].father;  
                    t[TchCounter].username = h[i].username;
                    t[TchCounter].password = h[i].password;
                    t[TchCounter].dateOfBirth = h[i].dateOfBirth;
                    t[TchCounter].gender = h[i].gender;
                    t[TchCounter].pet = h[i].pet;
                    t[TchCounter].simultaneousTeaching = Convert.ToBoolean(r3.Next(0, 1));

                    TchCounter++;

                }
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

            string[] letters = new string[100];
            int temp1 = 0;
            int[] temps = new int[100];
            int y = 0;

            //}
            int k = 0;
            int groupCounter = 0;






            // raftan be qazakhori

            Group[] group = new Group[300];

            Dorm[] dorm = new Dorm[300];


            for (i = 0; i < studentNum; i++)
            {

                group[i] = new Group();
                var value = Group.RandomEnumValue<Type>();
                group[i].type = value.ToString();
                group[i].name = s[i].name;
                group[i].family = s[i].family;
                s[i].Group = group[i].type;
                if(i<teacherNum)
                t[i].Group = group[i].type;



            }
            int dormcounter = 0;

            // khabgah ha
            try
            {
                for (k = 1; k <= 6; k++)
                {
                    for (j = 1; j <= 10; j++)
                    {
                        for (i = 1; i <= 5; i++)
                        {
                            dorm[dormcounter] = new Dorm(i,j,k);
                            



                            s[dormcounter]._roomnum = dorm[dormcounter].room;
                            s[dormcounter]._bednum = dorm[dormcounter].bed;
                            s[dormcounter]._floornum = dorm[dormcounter].floor;

                            dormcounter++;

                        }
                    }
                }
            }
            catch
            {
                dorm[dormcounter].bed = 0;
                dorm[dormcounter].room = 0;
                dorm[dormcounter].floor = 0;
            }









            while (true)
            {

                Massages.choise();
                string Choise = Console.ReadLine();

                switch (Choise)
                {
                    case "s":
                        {

                            Console.WriteLine("enter your name and family : ");
                            bool stuAllow = false;

                            string aimName = Console.ReadLine();
                            string aimFamily = Console.ReadLine();
                            for (i = 0; i < studentNum; i++)
                            {
                                if (s[i].name == aimName && s[i].family == aimFamily)
                                {
                                    stuAllow = true;
                                    temp = i;
                                }
                            }
                            if (stuAllow)
                            {
                                Console.WriteLine("go to hagvarts(g)");
                                Console.WriteLine("your letter : ");
                                Dambeldor.SendLetter(s[temp].name, s[temp].family, s[temp].timeGo, s[temp].cabinNum, s[temp].sitNum);

                                //string go = Console.ReadLine();
                                //DateTime goingtime = new DateTime();
                                //if (go == "g")
                                //{

                                //    if (DateTime.Now > s[temp].timeGo)
                                //    {
                                //        Console.WriteLine("you can't go right now because The time to go has passed");
                                //    }
                                //    else
                                //    {
                                Massages.studentChoise();
                                string stuChoise = Console.ReadLine();
                                switch (stuChoise)
                                {
                                    case "i":

                                        Console.ForegroundColor= ConsoleColor.Yellow;

                                        Console.WriteLine($"name : {s[temp].name}");
                                        Thread.Sleep(500);
                                        Console.WriteLine($"family : {s[temp].family}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"dateOfBirth : {s[temp].dateOfBirth}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"gender : {s[temp].gender}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"father : {s[temp].father}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"username : {s[temp].username}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"password : {s[temp].password}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"raceType : {s[temp].racetype}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"role : student");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"group : {s[temp].Group}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"haveing luggage : {s[temp].Luggage}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"pet : {s[temp].pet}");
                                        Thread.Sleep(500);

                                        Console.WriteLine($"dorm => floor : {s[temp]._floornum} room : {s[temp]._roomnum} bed : {s[temp]._bednum} ");

                                        break;


                                    case "p":

                                        {



                                            break;
                                        }
                                    case "s":

                                        break;


                                    case "d":

                                        break;
                                    case "l":
                                        Console.WriteLine("last letter : ");
                                        Console.WriteLine(" You are allowed to come to hagvarts.");
                                        Dambeldor.SendLetter(s[temp].name, s[temp].family, s[temp].timeGo, s[temp].cabinNum, s[temp].sitNum);
                                        break;
                                    case "sd":
                                        {
                                            Console.WriteLine("write your name and family then write your letter to send : ");
                                            string aimStuName = Console.ReadLine();
                                            string aimStuFamily = Console.ReadLine();
                                            string stuLetter = Console.ReadLine();

                                            for (i = 0; i < studentNum; i++)
                                            {
                                                if (s[i].name == aimStuName && s[i].family == aimStuFamily)
                                                {




                                                    letters[k] = stuLetter;
                                                    k++;
                                                    temps[y] = i;

                                                }
                                            }

                                            break;
                                        }



                                }






                            }

                            break;
                        }
                    case "t":
                        {
                            


                            Console.WriteLine("enter your name and family : ");
                            bool tchAllow = false;

                            string aimName = Console.ReadLine();
                            string aimFamily = Console.ReadLine();
                            for (i = 0; i < teacherNum; i++)
                            {
                                if (t[i].name == aimName && t[i].family == aimFamily)
                                {
                                    tchAllow = true;
                                    temp = i;
                                }
                            }
                            if (tchAllow)
                            {
                                Massages.teacherChoise();
                                string tchChoise = Console.ReadLine();
                                switch (tchChoise)
                                {
                                    case "i":
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine($"name : {t[temp].name}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"family : {t[temp].family}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"dateOfBirth : {t[temp].dateOfBirth}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"gender : {t[temp].gender}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"father : {t[temp].father}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"username : {t[temp].username}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"password : {t[temp].password}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"raceType : {t[temp].racetype}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"role : {t[temp].role}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"group : {t[temp].Group}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"haveing luggage : {t[temp].Luggage}");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"pet : {t[temp].pet}");
                                            Thread.Sleep(500);

                                            Console.ResetColor();

                                            Console.WriteLine(" if you like to add another lesson write 'yes' else write no");
                                            string teacheradd = Console.ReadLine();

                                            if (teacheradd == "yes")
                                            {
                                                if (t[temp].simultaneousTeaching == true)
                                                {
                                                    Console.WriteLine("write the lesson name : ");

                                                    t[temp].Lesson2 = Console.ReadLine();
                                                    Console.WriteLine("write the lesson time : ");
                                                    t[temp].TimeClass2 = Console.ReadLine();
                                                }
                                                else { Console.WriteLine("you can't have two lessons"); }

                                            }


                                            break;
                                        }
                                    case "p":
                                        {
                                            Random r1 = new Random();
                                            var list = new List<string> { "Sport", "Literature", "Botancial", "Math", "Physics" };

                                            DateTime date = DateTime.Now;
                                            Random r = new Random();
                                            for (i = 0; i < teacherNum; i++)
                                            {
                                                int index = r.Next(list.Count);
                                                t[i].Lesson1 = list[index];

                                                t[i].TimeClass1 = Convert.ToString(r.Next(date.Day, date.Hour));



                                            }


                                            break;
                                        }
                                    case "s":
                                        {
                                            break;
                                        }
                                    case "g":
                                        {
                                            Group huffle = new Group();
                                            Console.WriteLine("choose one : \n Hufflepuff       Gryffindor      Slytherin       Ravenclaw");
                                            string GroupName = Console.ReadLine();
                                            switch (GroupName)
                                            {
                                                case "Hufflepuff":
                                                    {
                                                        Console.WriteLine("the list of Hufflepuff is : ");

                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            if (group[i].type == "Hufflepuff")
                                                            {
                                                                Console.WriteLine(group[i].name + " " + group[i].family);

                                                            }
                                                        }

                                                        break;
                                                    }
                                                case "Gryffindor":
                                                    {
                                                        Console.WriteLine("the list of Gryffindor is : ");

                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            if (group[i].type == "Gryffindor")
                                                            {
                                                                Console.WriteLine(group[i].name + " " + group[i].family);

                                                            }
                                                        }

                                                        break;
                                                    }
                                                case "Ravenclaw":
                                                    {
                                                        Console.WriteLine("the list of Ravenclaw is : ");

                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            if (group[i].type == "Ravenclaw")
                                                            {
                                                                Console.WriteLine(group[i].name + " " + group[i].family);


                                                            }
                                                        }

                                                        break;
                                                    }
                                                case "Slytherin":
                                                    {
                                                        Console.WriteLine("the list of Slytherin is : ");
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            if (group[i].type == "Slytherin")
                                                            {
                                                                Console.WriteLine(group[i].name + " " + group[i].family);

                                                            }
                                                        }
                                                        break;
                                                    }
                                                default:
                                                    break;
                                            }
                                            break;
                                        }
                                }



                            }
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



                                        Random random = new Random();
                                        DateTime[] myDateTime = new DateTime[100];

                                        myDateTime[q - 1] = new DateTime(2023, 1, random.Next(1, 31), random.Next(0, 24), random.Next(0, 60), 0);
                                        s[q - 1].timeGo = myDateTime[q - 1];
                                        s[q - 1].cabinNum = random.Next(1, 55);
                                        s[q - 1].sitNum = random.Next(1, 4);
                                        Console.WriteLine(" You are allowed to come to hagvarts.");
                                        Dambeldor.SendLetter(s[q - 1].name, s[q - 1].family, s[q - 1].timeGo, s[q - 1].cabinNum, s[q - 1].sitNum);



                                        //}
                                        break;
                                    }
                                case "l":
                                    {
                                        break;
                                    }
                                case "i":
                                    {

                                        for (i = k - 1; i >= 0; i--)
                                        {
                                            Console.WriteLine($" '{letters[i]}' from : {s[temps[y]].name} {s[temps[y]].family} ");

                                            Console.WriteLine($"will you let {s[temps[y]].name} {s[temps[y]].family} ? ");
                                            string allow = Console.ReadLine();
                                            if (allow == "yes")
                                            {
                                                //Console.WriteLine("writ");
                                                //string NameA = Console.ReadLine();
                                                //string FamilyA = Console.ReadLine();


                                                //string NameAim = Console.ReadLine();


                                                Random random = new Random();
                                                DateTime[] myDateTime = new DateTime[100];


                                                myDateTime[temps[y]] = new DateTime(2023, 1, random.Next(1, 31), random.Next(0, 24), random.Next(0, 60), 0);
                                                s[temps[y]].timeGo = myDateTime[temps[y]];
                                                s[temps[y]].cabinNum = random.Next(1, 55);
                                                s[temps[y]].sitNum = random.Next(1, 4);
                                                Dambeldor.SendLetter(s[temps[y]].name, s[temps[y]].family, s[temps[y]].timeGo, s[temps[y]].cabinNum, s[temps[y]].sitNum);
                                            }
                                            y++;
                                        }



                                        break;
                                    }
                            }
                            break;
                        }

                    default:
                        break;

                }
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("do you want do continue ? press 'y'");
                string permission = Console.ReadLine();
                if (permission == "y")
                {
                    Console.Clear();
                }
                Console.ResetColor();

            }






















            Console.ReadKey();













        }

    }
}


