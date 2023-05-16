using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Student : AllowedPeople
    {
        public string[] _passedUnits = new string[25];
        public string[] _failedUnits = new string[25];


        public int _semester;
        public int _bednum;
        public int _roomnum;
        public int _floornum;
        public int ScoreSemester1;
        public int ScoreSemester2;
        public int ScoreSemester3;
        public int ScoreSemester4;
        public int Sport1Score;
        public int Sport2Score;
        public int Math1Score;
        public int Math2Score;
        public int Physics1Score;
        public int Physics2Score;
        public int LiteratureScore;
        public int ChemistryScore;
        //public string dormnum(int a, int b , int c)
        //{
        //    this._bednum = a;
        //    this._roomnum = b;
        //    this._floornum = c;
        //    return $"floor : {_floornum}  room : {_roomnum}  bed : {_bednum}";

        //}
        //public v (int bednum,int roomnum,int floornum)
        //{
        //    this._bednum = bednum;
        //    this._roomnum = roomnum;
        //    this._floornum = floornum;
        //}


        //public Student(string Name, string Family, DateTime TimeGo, int CabinNum, int SitNum)
        //{
        //    this.name = Name;
        //    this.family = Family;
        //    this.timeGo = TimeGo;
        //    this.cabinNum = CabinNum;
        //    this.sitNum = SitNum;

        //}


    }
}
