using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHousingBv
{
    public class BuildingClass
    {
        private List<TaskClass> tasks = new List<TaskClass>();
        private List<StudentClass> students = new List<StudentClass>();
        private List<FacilityClass> facilities = new List<FacilityClass>();
        StudentClass student;
        FacilityClass facility;
        private static int idSeeder = 100;

        // Properties
        public String Name
        {
            get;
            set;
        }

        /**
         * Method to add a task to a building
         */
        public void AddTasksToBuilding( string time, string studentName, string facilityName, string buildingName )
        {
            TaskClass task = new TaskClass( time, studentName, facilityName, buildingName );
            tasks.Add(task);
        }

        /**
         * Method to add a facility to a building
         */
        public void AddFacilityToBuilding( String name )
        {
            facility = new FacilityClass();
            facility.SetName( name );
            facility.GetName();
            facilities.Add( facility );
        }

        /**
         * Method to add a student to a building
         */
        public void AddStudentToBuilding(String name, String buildingName)
        {
            student = new StudentClass();
            student.ID += idSeeder;
            idSeeder++;
            student.SetName( name );
            student.GetName();
            student.SetBuildingName( buildingName );
            student.GetBuildingName();
            students.Add( student );
        }

        /**
         * Method to get student based on ID
         */
        public StudentClass GetStudent(int id)
        {
            foreach(StudentClass student in students)
            {
                if(student.ID == id)
                {
                    return student;
                }
            }

            return null;
        }

        /**
         * Method to remove a student based on ID
         */
        public bool RemoveStudent(int id)
        {
            StudentClass student = this.GetStudent( id );
            if( student != null )
            {
                this.students.Remove( student );
                return true;
            }
            return false;
        }

        /**
         * Method to get all students
         */
        public List<StudentClass> GetStudents()
        {
            return students;
        }

        /**
         * Method to get all tasks
         */
        public List<TaskClass> GetTasks()
        {
            return tasks;
        }

        /**
         * Method to get all facilities
         */
        public List<FacilityClass> GetFacilities()
        {
            return facilities;
        }
    }
}
