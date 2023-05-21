using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;

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
            var list3 = new List<string> { "cat","rat","owl"};

            
            Random petr = new Random();
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
                

                //h[i].pet = Enum.Parse(,list3[petr.Next(0, 2)], true);

                //h[i].racetype = human[j];
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
            for (i = 0; i < 300; i++)
            {
                switch (Convert.ToString(petr.Next(list3.Count)))
                {
                    case "rat":
                        {
                            h[i].pet = Pet.rat;
                            break;
                        }
                    case "owl":
                        {
                            h[i].pet = Pet.owl;
                            break;
                        }
                    case "cat":
                        {
                            h[i].pet = Pet.cat;
                            break;
                        }
                    default:
                        break;
                }
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
            Teacher[] t = new Teacher[300];
            Random r3 = new Random();
            for (i = 0; i < 300; i++)
            {
                if (h[i].role == Role.teacher)
                {

                    t[TchCounter] = new Teacher();
                    t[TchCounter].name = h[i].name;
                    t[TchCounter].family = h[i].family;
                    t[TchCounter].father = h[i].father;
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
            int dambeldorinbox = 0;
            int groupCounter = 0;
            int passedunitCounter = 0;
            int failedunitcounter = 0;
            //int ScoreSemester1 = 0;
            //int ScoreSemester2 = 0;
            //int ScoreSemester3 = 0;
            //int ScoreSemester4 = 0;

            int k = 0;

            int lessoncounter = 0;

            int LessonsNumber = 5;

            int currentSemester = 1;

            int avg = 0;


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
                if (i < teacherNum)
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
                            dorm[dormcounter] = new Dorm(i, j, k);




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
                //s[dormcounter]._bednum = 0;
                //s[dormcounter]._roomnum = 0;
                //s[dormcounter]._floornum = dorm[dormcounter].floor;





            }

            Lesson[] lesson = new Lesson[20];
            for (i = 0; i < 20; i++)
            {
                lesson[i] = new Lesson();
            }





            while (true)
            {

                Massages.Title();

                Massages.choise();
                string Choise = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Massages.loading();
                //Thread.Sleep(1000);
                Console.ResetColor();

                switch (Choise)
                {
                    case "s":
                        {
                            Console.Clear();
                            Massages.Title();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("enter your name and family : ");
                            bool stuAllow = false;
                            Console.ResetColor();

                            string aimName = Console.ReadLine();
                            string aimFamily = Console.ReadLine();
                            Console.Clear();
                            Massages.Title();
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

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("your letter : ");
                                Dambeldor.SendLetter(s[temp].name, s[temp].family, s[temp].timeGo, s[temp].cabinNum, s[temp].sitNum);
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                Console.WriteLine("go to hagvarts(g)");

                                Console.ResetColor();
                                string go = Console.ReadLine();
                                DateTime goingtime = new DateTime();
                                Massages.loading();
                                Console.Clear();
                                Massages.Title();



                                if (go == "g")
                                {



                                    if (DateTime.Now > s[temp].timeGo)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("you can't go right now because The time to go has passed");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("Please wait until your group is determined at Hogwarts...");





                                        Thread.Sleep(3000);
                                        Console.Clear();
                                        Massages.Title();
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine($"Hi {s[temp].name} {s[temp].family} welcome to hagvarts. your group is : {s[temp].Group}");
                                        Massages.studentChoise();
                                        Console.ResetColor();
                                        string stuChoise = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Massages.loading();
                                        Console.ResetColor();
                                        switch (stuChoise)
                                        {
                                            case "i":

                                                Console.ForegroundColor = ConsoleColor.DarkGreen;

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
                                                Thread.Sleep(500);
                                                Console.ResetColor();
                                                Console.ForegroundColor = ConsoleColor.Cyan;

                                                Console.WriteLine("list of lessons(ll)");
                                                Console.ResetColor();
                                                string ll = Console.ReadLine();
                                                if (ll == "ll")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Random randomdayofweek = new Random();
                                                    var list2 = new List<string> { "satarday", "sunday", "monday", "tuesday", "thursday" };
                                                    int index2 = randomdayofweek.Next(list2.Count);

                                                    Console.WriteLine($"Sport1     |:teacher :  {t[r3.Next(0, 80)].family} |time => day : {list2[randomdayofweek.Next(list2.Count)]}    |hour : {randomdayofweek.Next(1, 24)} ");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------");
                                                    Thread.Sleep(1000);
                                                    Console.WriteLine($"Literature |:teacher : {t[r3.Next(0, 80)].family}  |time : => day : {list2[randomdayofweek.Next(list2.Count)]}  |hour : {randomdayofweek.Next(1, 24)} ");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------");
                                                    Thread.Sleep(1000);
                                                    Console.WriteLine($"Botancial  |:teacher : {t[r3.Next(0, 80)].family}  |time : => day : {list2[randomdayofweek.Next(list2.Count)]}  |hour : {randomdayofweek.Next(1, 24)} ");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------");
                                                    Thread.Sleep(1000);
                                                    Console.WriteLine($"Math1      |:teacher : {t[r3.Next(0, 80)].family}  |time :  => day : {list2[randomdayofweek.Next(list2.Count)]} |hour : {randomdayofweek.Next(1, 24)} ");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------");
                                                    Thread.Sleep(1000);
                                                    Console.WriteLine($"Physics1   |:teacher : {t[r3.Next(0, 80)].family}  |time :  => day : {list2[randomdayofweek.Next(list2.Count)]} |hour : {randomdayofweek.Next(1, 24)} ");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------");
                                                    Thread.Sleep(1000);

                                                    for (i = 0; i < lessoncounter; i++)
                                                    {
                                                        Console.WriteLine($"{lesson[temp].nameL[i]} : time => day : {lesson[temp].DayL[i]} hour : {lesson[temp].hourtime[i]}");
                                                        Thread.Sleep(1000);
                                                    }
                                                    Console.ResetColor();
                                                    //List<Lesson> term1Lessonsex = LessonMg.Term1Lessons();
                                                    //for (i = 0; i < term1Lessonsex.Count; i++)
                                                    //{
                                                    //    Console.WriteLine(term1Lessonsex[i].nameL + "  " + term1Lessonsex[i].timeL);
                                                    //}
                                                    Console.ForegroundColor = ConsoleColor.Cyan;

                                                    Console.WriteLine("choose a lesson that  you want to take a test : ");
                                                    Console.ResetColor();
                                                    string aimlesson = Console.ReadLine();
                                                    Random randomScore = new Random();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Massages.loading();
                                                    Console.ResetColor();
                                                    switch (aimlesson)
                                                    {
                                                        case "Sport1":
                                                            {

                                                                s[temp].Sport1Score = randomScore.Next(5, 20);
                                                                if (s[temp].Sport1Score > 10)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                                    Console.WriteLine("congratulations! you paased this lesson. ");
                                                                    s[temp]._passedUnits[passedunitCounter] = "Sport";
                                                                    passedunitCounter++;

                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                    Console.WriteLine("you failed! because you didn't get the enough score to pass this lesson. ");
                                                                    s[temp]._failedUnits[failedunitcounter] = "Sport1";
                                                                    failedunitcounter++;
                                                                }
                                                                Console.ResetColor();
                                                                break;
                                                            }
                                                        case "Literature":
                                                            {

                                                                s[temp].LiteratureScore = randomScore.Next(5, 20);
                                                                if (s[temp].LiteratureScore > 10)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                                    Console.WriteLine("congratulations! you paased this lesson. ");
                                                                    s[temp]._passedUnits[passedunitCounter] = "Literature";
                                                                    passedunitCounter++;
                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                    Console.WriteLine("you failed! because you didn't get the enough score to pass this lesson. ");
                                                                    s[temp]._failedUnits[failedunitcounter] = "Literature";
                                                                    failedunitcounter++;
                                                                }
                                                                Console.ResetColor();
                                                                break;
                                                            }
                                                        case "Botancial":
                                                            {
                                                                int scoreBotancial = randomScore.Next(5, 20);
                                                                if (scoreBotancial > 10)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                                    Console.WriteLine("congratulations! you paased this lesson. ");
                                                                    s[temp]._passedUnits[passedunitCounter] = "Botancial";
                                                                    passedunitCounter++;
                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                    Console.WriteLine("you failed! because you didn't get the enough score to pass this lesson. ");
                                                                    s[temp]._failedUnits[failedunitcounter] = "Botancial";
                                                                    failedunitcounter++;
                                                                }
                                                                Console.ResetColor();
                                                                break;
                                                            }
                                                        case "Math1":
                                                            {
                                                                s[temp].Math1Score = randomScore.Next(5, 20);
                                                                if (s[temp].Math1Score > 10)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                                    Console.WriteLine("congratulations! you paased this lesson. ");
                                                                    s[temp]._passedUnits[passedunitCounter] = "Math1";
                                                                    passedunitCounter++;
                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                    Console.WriteLine("you failed! because you didn't get the enough score to pass this lesson. ");
                                                                    s[temp]._failedUnits[failedunitcounter] = "Math1";
                                                                    failedunitcounter++;
                                                                }
                                                                Console.ResetColor();
                                                                break;
                                                            }
                                                        case "Physics1":
                                                            {
                                                                s[temp].Physics1Score = randomScore.Next(5, 20);
                                                                if (s[temp].Physics1Score > 10)
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                                    Console.WriteLine("congratulations! you paased this lesson. ");
                                                                    s[temp]._passedUnits[passedunitCounter] = "Physics1";
                                                                    passedunitCounter++;
                                                                }
                                                                else
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                    Console.WriteLine("you failed! because you didn't get the enough score to pass this lesson. ");
                                                                    s[temp]._failedUnits[failedunitcounter] = "Physics1";
                                                                    failedunitcounter++;
                                                                }
                                                                Console.ResetColor();
                                                                break;
                                                            }

                                                        default:
                                                            break;
                                                    }

                                                }
                                                Console.Clear();
                                                Massages.Title();
                                                break;


                                            case "p":

                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.WriteLine("List of passed lessons : ");
                                                    for (i = 0; i < s[temp]._passedUnits.Length; i++)
                                                    {
                                                        if (s[temp]._passedUnits[i] == null)
                                                            break;
                                                        Console.WriteLine(s[temp]._passedUnits[i]);
                                                        Thread.Sleep(500);
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("select unit :SU");

                                                    string unitChoise = Console.ReadLine();
                                                    if (unitChoise == "SU")
                                                    {
                                                        if (lessoncounter == 1)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("you can select unit :");
                                                            Console.WriteLine("units : ");
                                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                            Console.WriteLine($"Sport2       Math2       Physics2        Chemistry       Occultism      ");
                                                            for (i = 0; i < failedunitcounter; i++)
                                                            {

                                                                Console.WriteLine(s[temp]._failedUnits[i]);
                                                            }
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("select lessons that you want to choose(you can maximum choose 5 lesson) :");

                                                            string ask = "yes";


                                                            while (ask == "yes")
                                                            {

                                                                Random randomdayofweek = new Random();

                                                                var list2 = new List<string> { "satarday", "sunday", "monday", "tuesday", "thursday" };


                                                                Student[] lessons = new Student[20];
                                                                lessons[lessoncounter] = new Student(lesson[temp], lessoncounter);
                                                                lessoncounter++;
                                                                //lesson[temp].nameL[lessoncounter] = Console.ReadLine();
                                                                //lesson[temp].DayL[lessoncounter] = list2[randomdayofweek.Next(list2.Count)];
                                                                //lesson[temp].hourtime[lessoncounter] = Convert.ToString(randomdayofweek.Next(1, 24));
                                                                Console.WriteLine("if you want to continue choosing press yes");
                                                                ask = Console.ReadLine();
                                                            }
                                                        }

                                                        else
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("you can't select unit because you hasn't passed the previous lessons !");

                                                            Console.ResetColor();
                                                        }



                                                    }



                                                    break;
                                                }
                                            //case "s":

                                            //    break;


                                            case "d":

                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                                                    Console.WriteLine($"floor : {s[temp]._floornum}  room : {s[temp]._roomnum}  bed : {s[temp]._bednum} ");

                                                }
                                                break;
                                            case "l":
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("last letter : ");
                                                Thread.Sleep(500);
                                                Console.WriteLine(" You are allowed to come to hagvarts.");
                                                Thread.Sleep(500);
                                                Console.ResetColor();
                                                Dambeldor.SendLetter(s[temp].name, s[temp].family, s[temp].timeGo, s[temp].cabinNum, s[temp].sitNum);
                                                break;
                                            case "sd":
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("enter your name : ");
                                                    Console.ResetColor();
                                                    string aimStuName = Console.ReadLine();
                                                    Console.ForegroundColor = ConsoleColor.Cyan;

                                                    Console.WriteLine("enter your family : ");
                                                    Console.ResetColor();

                                                    string aimStuFamily = Console.ReadLine();
                                                    Console.ForegroundColor = ConsoleColor.Cyan;

                                                    Console.WriteLine("write your letter : ");
                                                    Console.ResetColor();

                                                    string stuLetter = Console.ReadLine();

                                                    for (i = 0; i < studentNum; i++)
                                                    {
                                                        if (s[i].name == aimStuName && s[i].family == aimStuFamily)
                                                        {




                                                            letters[dambeldorinbox] = stuLetter;
                                                            dambeldorinbox++;
                                                            temps[y] = i;

                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("Your letter has sent to Dambeldor.");
                                                    Console.ResetColor();


                                                    break;
                                                }
                                            case "pr":
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("Enter your Semester : ");
                                                    Console.ResetColor();
                                                    string AimSemester = Console.ReadLine();
                                                    Console.ForegroundColor = ConsoleColor.Magenta;

                                                    Console.ResetColor();

                                                    switch (AimSemester)
                                                    {
                                                        case "1":
                                                            {

                                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                                Console.WriteLine($" You have to Collect and deliver these plants for semester{AimSemester} to the teacher :\nLavender\r\nGarlic\r\nBamboo\r\nDesert rose\r\n if You want to deliver your exercise enter 'y'");
                                                                Console.ResetColor();
                                                                string answer = Console.ReadLine();
                                                                Console.ResetColor();
                                                                if (answer == "y")
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                                    Console.WriteLine("Enter 4 name  plants that you have collected (if you couldn't collect, Enter nothing.) :  ");
                                                                    Console.ResetColor();
                                                                    s[temp].ScoreSemester1 += Botanical.TheListOfSemester1Plants(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

                                                                }


                                                                break;

                                                            }
                                                        case "2":
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                                Console.WriteLine($" You have to Collect and deliver these plants for semester{AimSemester} to the teacher :Elderberry\r\nAdenium obesum\r\nCucumber\r\nColumbine\r\n if You want to deliver your exercise enter 'y'");
                                                                Console.ResetColor();
                                                                string answer = Console.ReadLine();
                                                                Console.ResetColor();
                                                                if (answer == "y")
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                                    Console.WriteLine("Enter 4 name  plants that you have collected (if you couldn't collect, Enter nothing.) :  ");
                                                                    Console.ResetColor();
                                                                    s[temp].ScoreSemester2 = Botanical.TheListOfSemester2Plants(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

                                                                }
                                                                break;
                                                            }
                                                        case "3":
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.Cyan;

                                                                Console.WriteLine($" You have to Collect and deliver these plants for semester{AimSemester} to the teacher :Ivy\r\nClover\r\nEnglish lavender\r\nCabbage\r\n if You want to deliver your exercise enter 'y'");
                                                                Console.ResetColor();
                                                                string answer = Console.ReadLine();
                                                                Console.ResetColor();
                                                                if (answer == "y")
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                                    Console.WriteLine("Enter 4 name  plants that you have collected (if you couldn't collect, Enter nothing.) :  ");
                                                                    Console.ResetColor();
                                                                    s[temp].ScoreSemester3 = Botanical.TheListOfSemester2Plants(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

                                                                }
                                                                break;
                                                            }
                                                        case "4":
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.Cyan;

                                                                Console.WriteLine($" You have to Collect and deliver these plants for semester{AimSemester} to the teacher :Daisy\r\nLove-Lies-Bleeding\r\nNeem Tree\r\nrose\r\n if You want to deliver your exercise enter 'y'");
                                                                Console.ResetColor();
                                                                string answer = Console.ReadLine();
                                                                Console.ResetColor();
                                                                if (answer == "y")
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                                    Console.WriteLine("Enter 4 name  plants that you have collected (if you couldn't collect, Enter nothing.) :  ");
                                                                    Console.ResetColor();
                                                                    s[temp].ScoreSemester4 = Botanical.TheListOfSemester2Plants(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

                                                                }
                                                                break;
                                                            }

                                                        default:
                                                            break;
                                                    }
                                                    Console.WriteLine("Your practice saved and teacher will grade.");
                                                    break;
                                                }
                                            case "ScoreB":
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("Enter your Semester : ");
                                                    Console.ResetColor();
                                                    string AimSemester = Console.ReadLine();
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    if (AimSemester == "1")
                                                        Console.WriteLine($"Your score of Botanical in semester {AimSemester} is : {s[temp].ScoreSemester1}");
                                                    if (AimSemester == "2")
                                                        Console.WriteLine($"Your score of Botanical in semester {AimSemester} is : {s[temp].ScoreSemester2}");
                                                    if (AimSemester == "3")
                                                        Console.WriteLine($"Your score of Botanical in semester {AimSemester} is : {s[temp].ScoreSemester3}");
                                                    if (AimSemester == "4")
                                                        Console.WriteLine($"Your score of Botanical in semester {AimSemester} is : {s[temp].ScoreSemester4}");
                                                    Console.ResetColor();
                                                    break;
                                                }

                                            //Console.WriteLine("your lessons are : Sport, Literature, Botancial, Math, Physics");
                                            //Console.WriteLine($"sport :teacher : {t[temp].name} {t[temp].family} time : {t[temp].TimeClass1}");
                                            //Console.WriteLine(t[temp].Lesson1);
                                            //Console.WriteLine(t[temp].TimeClass1);
                                            //var list2 = new List<string> { "Sport", "Literature", "Botancial", "Math", "Physics" };

                                            //DateTime date2 = DateTime.Now;
                                            //Random r2 = new Random();
                                            //for (i = 0; i < teacherNum; i++)
                                            //{
                                            //    int index = r2.Next(list2.Count);
                                            //    t[i].Lesson1 = list2[index];

                                            //    t[i].TimeClass1 = Convert.ToString(r2.Next(date2.Day, date2.Hour));



                                            //}

                                            case "log":
                                                {
                                                    Massages.logSemester1(s, temp);
                                                    int sum = s[temp].Physics1Score + s[temp].ScoreSemester1 + s[temp].Math1Score + s[temp].Sport1Score;
                                                    avg = sum / LessonsNumber;
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine($"average => {avg}");
                                                    if (avg > 10)
                                                    {
                                                        Console.WriteLine("you passed this semester and you can go next semester.");
                                                        currentSemester++;
                                                    }
                                                    Console.ResetColor();
                                                    break;
                                                }








                                        }





                                    }
                                }



                            }



                            break;
                        }



                    case "t":
                        {

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("enter your name and family : ");
                            bool tchAllow = false;
                            Console.ResetColor();
                            string aimName = Console.ReadLine();
                            string aimFamily = Console.ReadLine();
                            Massages.loading();
                            Console.Clear();
                            Massages.Title();

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
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
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

                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine(" if you like to add another lesson write 'yes' else write no");
                                            Console.ResetColor();
                                            string teacheradd = Console.ReadLine();
                                            Massages.loading();
                                            Console.Clear();
                                            Massages.Title();
                                            if (teacheradd == "yes")
                                            {
                                                if (t[temp].simultaneousTeaching == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("write the lesson name : ");
                                                    Console.ResetColor();
                                                    t[temp].Lesson2 = Console.ReadLine();
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("write the lesson time : ");
                                                    Console.ResetColor();
                                                    t[temp].TimeClass2 = Console.ReadLine();
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.WriteLine("you can't have two lessons");
                                                    Console.ResetColor();
                                                }

                                            }


                                            break;
                                        }
                                    case "p":
                                        {

                                            var list = new List<string> { "Sport", "Literature", "Botancial", "Math", "Physics" };

                                            DateTime date = DateTime.Now;
                                            Random r = new Random();
                                            for (i = 0; i < teacherNum; i++)
                                            {
                                                int index = r.Next(list.Count);
                                                t[i].Lesson1 = list[index];

                                                t[i].TimeClass1 = Convert.ToString(r.Next(1, 24));




                                            }
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"Lesson : {t[temp].Lesson1}      Time : {t[temp].TimeClass1}");
                                            Console.ResetColor();

                                            break;
                                        }
                                    case "s":
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("Enter the Lesson");
                                            Console.ResetColor();
                                            string AimLesson = Console.ReadLine();
                                            Massages.loading();
                                            Console.Clear();
                                            Massages.Title();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;

                                            switch (AimLesson)
                                            {

                                                case "Sport1":
                                                    {
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.WriteLine($"{s[i].name}  {s[i].family} : {s[i].Sport1Score}");
                                                        }
                                                        break;
                                                    }
                                                case "Math1":
                                                    {
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.WriteLine($"{s[i].name}  {s[i].family} : {s[i].Math1Score}");
                                                        }
                                                        break;
                                                    }
                                                case "Chemistry":
                                                    {
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.WriteLine($"{s[i].name}  {s[i].family} : {s[i].ChemistryScore}");
                                                        }
                                                        break;
                                                    }
                                                case "Physics":
                                                    {
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.WriteLine($"{s[i].name}  {s[i].family} : {s[i].Physics1Score}");
                                                        }
                                                        break;
                                                    }
                                                case "Botanical":
                                                    {
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.WriteLine($"{s[i].name}  {s[i].family} : {s[i].ScoreSemester1}");
                                                        }
                                                        break;
                                                    }


                                            }
                                            Console.ResetColor();
                                            break;
                                        }
                                    case "g":
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Massages.loading();
                                            Console.Clear();
                                            Massages.Title();
                                            Group huffle = new Group();
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("choose one : \n Hufflepuff       Gryffindor      Slytherin       Ravenclaw");
                                            Console.ResetColor();
                                            string GroupName = Console.ReadLine();
                                            switch (GroupName)
                                            {
                                                case "Hufflepuff":
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine("the list of Hufflepuff is : ");

                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                            if (group[i].type == "Hufflepuff")
                                                            {
                                                                Console.WriteLine(group[i].name + " " + group[i].family);

                                                            }
                                                        }
                                                        Console.ResetColor();

                                                        break;
                                                    }
                                                case "Gryffindor":
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;

                                                        Console.WriteLine("the list of Gryffindor is : ");

                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.DarkGreen;

                                                            if (group[i].type == "Gryffindor")
                                                            {
                                                                Console.WriteLine(group[i].name + " " + group[i].family);

                                                            }
                                                        }
                                                        Console.ResetColor();

                                                        break;
                                                    }
                                                case "Ravenclaw":
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;

                                                        Console.WriteLine("the list of Ravenclaw is : ");

                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            if (group[i].type == "Ravenclaw")
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                                                Console.WriteLine(group[i].name + " " + group[i].family);


                                                            }
                                                        }

                                                        break;
                                                    }
                                                case "Slytherin":
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine("the list of Slytherin is : ");
                                                        for (i = 0; i < studentNum; i++)
                                                        {
                                                            if (group[i].type == "Slytherin")
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                                                Console.WriteLine(group[i].name + " " + group[i].family);

                                                            }
                                                            Console.ResetColor();
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
                            //Console.ForegroundColor = ConsoleColor.DarkYellow;
                            //Console.WriteLine("Loading...");
                            //Thread.Sleep(2000);
                            //Console.ResetColor();
                            //Thread.Sleep(2000);
                            Massages.dambeldorChoise();
                            string dambeldorChoose = Console.ReadLine();

                            switch (dambeldorChoose)
                            {

                                case "s":
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Massages.loading();
                                        Console.WriteLine("Send letter to all students(sendall)         send letter to one person(sendone)");
                                        Console.ResetColor();
                                        string sendletter = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Massages.loading();
                                        
                                        Console.Clear();
                                        Massages.Title();


                                        if (sendletter == "sendall")
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Massages.loading();
                                            Console.ResetColor();
                                            Console.Clear();
                                            Massages.Title();

                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            //for (i = 0; i < 300; i++)
                                            //{
                                            //Console.WriteLine("write the people index number : ");
                                            Console.ResetColor();
                                            //int q = int.Parse(Console.ReadLine());




                                            Random random = new Random();
                                            DateTime[] myDateTime = new DateTime[230];
                                            Console.WriteLine("Sending letter to students...");
                                            Thread.Sleep(5000);


                                            Console.Clear();
                                            Massages.Title();
                                            for (i = 1; i <= studentNum; i++)
                                            {
                                                myDateTime[i - 1] = new DateTime(2023, DateTime.Now.Month, random.Next(21, 31), random.Next(0, 24), random.Next(0, 60), 0);
                                                s[i - 1].timeGo = myDateTime[i - 1];
                                                s[i - 1].cabinNum = random.Next(1, 55);
                                                s[i - 1].sitNum = random.Next(1, 4);
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("Hi. You are allowed to come to hagvarts:)");
                                                Dambeldor.SendLetter(s[i - 1].name, s[i - 1].family, s[i - 1].timeGo, s[i - 1].cabinNum, s[i - 1].sitNum);
                                               

                                            }
                                            Console.ResetColor();
                                            Console.Clear();


                                        }
                                        if (sendletter == "sendone")
                                        {

                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("write index of someone to send letter :");
                                            Console.ResetColor();
                                            int q = int.Parse(Console.ReadLine());
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Massages.loading();
                                            Console.ResetColor();
                                            Console.Clear();
                                            Massages.Title();
                                            Random random = new Random();
                                            DateTime[] myDateTime = new DateTime[230];
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("Sending letter to student...");
                                            Console.ResetColor();
                                            Thread.Sleep(5000);

                                            myDateTime[q - 1] = new DateTime(2023, DateTime.Now.Month, random.Next(15, 31), random.Next(0, 24), random.Next(0, 60), 0);
                                            s[q - 1].timeGo = myDateTime[q - 1];
                                            s[q - 1].cabinNum = random.Next(1, 55);
                                            s[q - 1].sitNum = random.Next(1, 4);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;

                                            Console.WriteLine($"Hi {s[temp].name} {s[temp].family} . You are allowed to come to hagvarts:)");
                                            Console.ResetColor();
                                            Dambeldor.SendLetter(s[q - 1].name, s[q - 1].family, s[q - 1].timeGo, s[q - 1].cabinNum, s[q - 1].sitNum);


                                        }

                                        break;
                                    }
                                case "l":
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Massages.loading();
                                        Console.ResetColor();
                                        Console.Clear();
                                        Massages.Title();
                                        for (i = 0; i < studentNum; i++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine($"floor : {s[i]._floornum}  room : {s[i]._roomnum}  bed : {s[i]._bednum} => {s[i].name} {s[i].family} ");
                                            Console.ResetColor();

                                        }
                                        
                                        //Console.Clear();
                                        //Massages.Title();

                                        break;
                                    }
                                case "i":
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                        Massages.loading();
                                        Console.ResetColor();
                                        Console.Clear();
                                        Massages.Title();
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        if (dambeldorinbox == 0)
                                        {
                                            Console.WriteLine("You don't have any letter!");
                                        }
                                        for (i = dambeldorinbox - 1; i >= 0; i--)
                                        {


                                            Console.WriteLine($" '{letters[i]}' from : {s[temps[y]].name} {s[temps[y]].family} ");
                                            Console.ResetColor();
                                            Console.ForegroundColor = ConsoleColor.Cyan;

                                            Console.WriteLine($"will you let {s[temps[y]].name} {s[temps[y]].family} ? ");
                                            Console.ResetColor();
                                            string allow = Console.ReadLine();
                                            if (allow == "yes")
                                            {
                                                //Console.WriteLine("writ");
                                                //string NameA = Console.ReadLine();
                                                //string FamilyA = Console.ReadLine();


                                                //string NameAim = Console.ReadLine();


                                                Random random = new Random();
                                                DateTime[] myDateTime = new DateTime[100];


                                                myDateTime[temps[y]] = new DateTime(2023, DateTime.Now.Month, random.Next(1, 31), random.Next(0, 24), random.Next(0, 60), 0);
                                                s[temps[y]].timeGo = myDateTime[temps[y]];
                                                s[temps[y]].cabinNum = random.Next(1, 55);
                                                s[temps[y]].sitNum = random.Next(1, 4);
                                                Dambeldor.SendLetter(s[temps[y]].name, s[temps[y]].family, s[temps[y]].timeGo, s[temps[y]].cabinNum, s[temps[y]].sitNum);
                                            }
                                            y++;
                                        }


                                        Console.Clear();
                                        Massages.Title();
                                        break;
                                    }
                            }
                            //Console.Clear();
                            //Massages.Title();
                            break;
                        }

                    default:
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("press any key to continue...");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Massages.loading();


                Console.Clear();

                Console.ResetColor();

            }






















            Console.ReadKey();













        }

    }
}


