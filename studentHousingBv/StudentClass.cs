using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHousingBv
{
    public class StudentClass
    {
        private string name;
        private int loginCodeBuildingA = 1234;
        private int loginCodeBuildingB = 4321;
        private int loginCodeBuildingC = 2468;
        private string buildingName;

        public int ID
        {
            get;
            set;
        }

        public String SetName( string name )
        {
            return this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }

        public String SetBuildingName( string name )
        {
            return this.buildingName = name;
        }

        public String GetBuildingName()
        {
            return this.buildingName;
        }

        public int GetLoginCodeBuildingA()
        {
            return this.loginCodeBuildingA;
        }

        public int GetLoginCodeBuildingB()
        {
            return this.loginCodeBuildingB;
        }

        public int GetLoginCodeBuildingC()
        {
            return this.loginCodeBuildingC;
        }

        public String GetInfo()
        {
            return "ID:" + this.ID + " - " + "Student: " + this.GetName() + " - " + "lives in: " + this.GetBuildingName();
        }
    }
}
