using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public enum Type
    {
        Hufflepuff = 1,
        Gryffindor = 2,
        Ravenclaw = 3,
        Slytherin = 4
    };
    public class Group : Student
    {
        public Type _type;
        public string type;
        public int score;
        public string[] listOfpeopleInGp = new string[100];
        //public static void people(string name, string family, string Length)
        //{
        //    for (int i = 0; i < Length; i++)
        //    {
        //        Console.WriteLine(name + family);
        //    }
        //}
        public string listOfQPlayers;
    static Random _R = new Random();
    public static T RandomEnumValue<T>()
    {
        var v = Enum.GetValues(typeof(T));
        return (T)v.GetValue(_R.Next(v.Length));
    }
    //public static void ListOfGroup(string GroupName)
    //{
    //    while(GroupName == "Hufflepuff")
    //    {
    //        Console.WriteLine();
    //    }
    //}
}
}
