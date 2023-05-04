using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagvarts
{
    public class Student : AllowedPeople
    {
        public int passedUnits;
        public int semester;
        public int dormNumber;
        

        public Student(string Name, string Family, string TimeGo, string CabinNum, string SitNum)
        {
            this.name = Name;
            this.family = Family;
            this.timeGo = TimeGo;
            this.cabinNum = CabinNum;
            this.sitNum = SitNum;
            
        }

    }
}
