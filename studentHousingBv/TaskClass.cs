using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentHousingBv
{
    public class TaskClass
    {
        StudentClass student = new StudentClass();
        FacilityClass facility = new FacilityClass();
        BuildingClass building = new BuildingClass();

        // Properties
        public String StudentName
        {
            get;
            set;
        }
        public String FacilityName
        {
            get;
            set;
        }
        public String Time
        {
            get;
            set;
        }
        public String BuildingName
        {
            get;
            set;
        }

        /**
        * Constructor
        */
        public TaskClass( String time, String studentName, String facilityName, String buildingName )
        {
            student.SetName( studentName );
            facility.SetName( facilityName );
            building.Name = buildingName;
            this.Time = time;
            this.StudentName = student.GetName();
            this.FacilityName = facility.GetName();
            this.BuildingName = building.Name;
        }

        // Methods
        public String GetTaskInfo()
        {
            return this.Time +  " - " + this.StudentName + " - " + "Facility: " + this.FacilityName + " - " + "Building: " + this.BuildingName;
        }

        public override String ToString()
        {
            return this.Time + " - " + this.StudentName + " - " + "Facility: " + this.FacilityName + " - " + "Building: " + this.BuildingName;
        }
    }
}
