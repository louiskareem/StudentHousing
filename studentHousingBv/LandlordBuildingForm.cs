using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Globalization;

namespace studentHousingBv
{
    public partial class LandlordBuildingForm : Form
    {
        WebSocket ws;
        BuildingClass building = new BuildingClass();
        public List<string> buildings = new List<string>();
        public static List<String> rules = new List<string>();
        List<TaskClass> buildingsA = new List<TaskClass>();
        List<TaskClass> buildingsB = new List<TaskClass>();
        List<TaskClass> buildingsC = new List<TaskClass>();
        public static List<TaskClass> unassignedTasks = new List<TaskClass>();
        DateTime now = DateTime.Now;

        /**
         * Constructor
         */
        public LandlordBuildingForm()
        {
            InitializeComponent();
            //ws = new WebSocket();
            DateTime time = DateTime.Today;
            timer1.Start();

            tabControl.TabPages.Remove( buildingBTabPage );
            tabControl.TabPages.Remove( buildingCTabPage );
            tabControl.TabPages.Remove( buildingATabPage );

            building.AddStudentToBuilding( "Chris", "Building A");
            building.AddStudentToBuilding( "Rihanna", "Building A");
            building.AddStudentToBuilding( "Hoffa", "Building A" );
            building.AddStudentToBuilding( "Jabba", "Building A" );
            building.AddStudentToBuilding( "James", "Building A" );
            building.AddStudentToBuilding( "Mike", "Building A" );
            building.AddStudentToBuilding( "Katalina", "Building A" );

            building.AddStudentToBuilding( "Louis", "Building B" );
            building.AddStudentToBuilding( "Katrina", "Building B" );
            building.AddStudentToBuilding( "Mekka", "Building B" );
            building.AddStudentToBuilding( "Jordan", "Building B" );

            building.AddStudentToBuilding( "Justin", "Building C" );
            building.AddStudentToBuilding( "Drake", "Building C" );
            building.AddStudentToBuilding( "Jimmy", "Building C" );
            building.AddStudentToBuilding( "Derrick", "Building C" );

            building.AddFacilityToBuilding( "Pool" );
            building.AddFacilityToBuilding( "Kitchen" );
            building.AddFacilityToBuilding( "Gym" );
            building.AddFacilityToBuilding( "Hallway" );

            buildings.Add( "Building A" );
            buildings.Add( "Building B" );
            buildings.Add( "Building C" );

            rulesListBox.Items.Add( "Empty garbage on time." + "-" + now );
            rulesListBox.Items.Add( "Do not steal." + "-" + now );
            rulesListBox.Items.Add( "Do not hold unannounced parties." + "-" + now );
            rulesListBox.Items.Add( "Maintain cleanliness at all times." + "-" + now );
            rulesListBox.Items.Add( "Do groceries on time." + "-" + now );
            rulesListBox.Items.Add( "Observe all of the above." + "-" + now );

            for( DateTime _time = time.AddHours( 08 ); _time < time.AddHours( 24 ); _time = _time.AddMinutes( 60 ) ) //from 16h to 18h hours
            {
                timeAComboBox.Items.Add( _time.ToShortTimeString() );
                taskTimeAComboBox.Items.Add( _time.ToShortTimeString() );
                timeBComboBox.Items.Add( _time.ToShortTimeString() );
                taskTimeBComboBox.Items.Add( _time.ToShortTimeString() );
                timeCComboBox.Items.Add( _time.ToShortTimeString() );
                taskTimeCComboBox.Items.Add( _time.ToShortTimeString() );
            }

            foreach(FacilityClass facility in building.GetFacilities())
            {
                facilityAComboBox.Items.Add( facility );
                facilityBComboBox.Items.Add( facility );
                facilityCComboBox.Items.Add( facility );
            }

            foreach( string b in buildings )
            {
                buildingsComboBox.Items.Add( b );
            }

            foreach( StudentClass student in building.GetStudents() )
            {
                studentListBox.Items.Add( student.GetInfo() );
            }
        }

        /**
         * Method to add a student to a building
         */
        private void addTenantButton_Click( object sender, EventArgs e )
        {
            String name = studentNameTextBox.Text;
            String buildingName = buildingComboBox.SelectedItem.ToString();
            building.AddStudentToBuilding( name, buildingName );

            foreach(StudentClass student in building.GetStudents())
            {
                if(!studentListBox.Items.Contains(student.GetName()))
                {
                    studentListBox.Items.Clear();                   
                    
                    studentListBox.Items.Add( student.GetInfo() );
                }
            }

            // If the selected building is equal to building name then add to building's list
            if(buildingName == "Building A")
            {
                buildingsA.Add( new TaskClass( "Unknown", name, "Unknown", "A" ));
                unassignedTasks.Add(new TaskClass("Unknown", name, "Unknown", "A"));
            }
            else if(buildingName == "Building B")
            {
                buildingsB.Add( new TaskClass( "Unknown", name, "Unknown", "B" ) );
                unassignedTasks.Add( new TaskClass( "Unknown", name, "Unknown", "B" ) );
            }
            else if( buildingName == "Building C" )
            {
                buildingsC.Add( new TaskClass( "Unknown", name, "Unknown", "C" ) );
                unassignedTasks.Add( new TaskClass( "Unknown", name, "Unknown", "C" ) );
            }
        }

        /**
         * Method to show all students in every building
         */
        private void showAllStudentsButton_Click( object sender, EventArgs e )
        {
            studentListBox.Items.Clear();

            if( building.GetStudents().Count != 0)
            {
                foreach( StudentClass student in building.GetStudents() )
                {
                    studentListBox.Items.Add( student.GetInfo() );
                }
            }
            else
            {
                MessageBox.Show( "There are no students. Please contact management!" );
            }
        }

        /**
         * Method to remove a student from a building
         */
        private void removeStudentButton_Click( object sender, EventArgs e )
        {
            String name = removeStudentNameTextBox.Text;

            if(tabControl.Contains(buildingATabPage))
            {
                foreach( TaskClass task in buildingsA.ToList() )
                {

                    if( name == task.StudentName )
                    {

                        buildingsA.Remove( task );
                    }
                }

                int id = Convert.ToInt32( studentIdTextBox.Text );
                building.RemoveStudent( id );
                studentListBox.Items.Clear();
            }
            else if(tabControl.Contains(buildingBTabPage))
            {
                foreach( TaskClass task in buildingsB.ToList() )
                {
                    if( name == task.StudentName )
                    {
                        buildingsB.Remove( task );
                    }
                }

                int id = Convert.ToInt32( studentIdTextBox.Text );
                building.RemoveStudent( id );
                studentListBox.Items.Clear();
            }
            else if(tabControl.Contains(buildingCTabPage))
            {
                foreach( TaskClass task in buildingsC.ToList() )
                {
                    if( name == task.StudentName )
                    {
                       buildingsC.Remove( task );
                    }
                }

                int id = Convert.ToInt32( studentIdTextBox.Text );
                building.RemoveStudent( id );
                studentListBox.Items.Clear();
            }
            else
            {
                MessageBox.Show( "You can only remove a student if you've selected a building on the homepage!" );
            }

        }

        /**
         * Method to receive complaints from student
         */
        private void timer1_Tick( object sender, EventArgs e )
        {
            //complaintsListBox.Items.Clear();

            foreach( String complaint in TenantBuildingForm.complaints )
            {
                if( !complaintsListBox.Items.Contains( complaint ) )
                {
                    complaintsListBox.Items.Add( complaint );
                }
            }
        }

        /**
         * Method to go to a building based on the item selected from the dropdown list
         */
        private void goToBuildingButton_Click( object sender, EventArgs e )
        {
            int item = buildingsComboBox.SelectedIndex;

            switch( item )
            {
                case 0:
                    if( !tabControl.TabPages.Contains( buildingATabPage ) )
                    {
                        tabControl.TabPages.Remove( buildingBTabPage );
                        tabControl.TabPages.Remove( buildingCTabPage );
                        tabControl.TabPages.Insert( 1, buildingATabPage );
                        tabControl.SelectTab( buildingATabPage );
                        buildingAListBox.Items.Clear();

                        foreach( var a in TenantBuildingForm.buildingTasks )
                        {
                            buildingsA.Add( a );

                            string buildingName = a.GetTaskInfo().Trim().Split().Last();

                            if( buildingName == "A" )
                            {
                                buildingAListBox.Items.Add( a.GetTaskInfo() );
                            }
                        }
                    }
                    else
                    {
                        tabControl.SelectTab( buildingATabPage );
                    }
                    break;
                case 1:
                    if( !tabControl.TabPages.Contains( buildingBTabPage ) )
                    {
                        tabControl.TabPages.Remove( buildingATabPage );
                        tabControl.TabPages.Remove( buildingCTabPage );
                        tabControl.TabPages.Insert( 1, buildingBTabPage );
                        tabControl.SelectTab( buildingBTabPage );
                        buildingBListBox.Items.Clear();

                        foreach( var b in TenantBuildingForm.buildingTasks )
                        {
                            buildingsB.Add( b );

                            string buildingName = b.GetTaskInfo().Trim().Split().Last();
                            if( buildingName == "B" )
                            {
                                buildingBListBox.Items.Add( b.GetTaskInfo() );
                            }
                        }
                    }
                    else
                    {
                        tabControl.SelectTab( buildingBTabPage );
                    }
                    break;
                case 2:
                    if( !tabControl.TabPages.Contains( buildingCTabPage ) )
                    {
                        tabControl.TabPages.Remove( buildingBTabPage );
                        tabControl.TabPages.Remove( buildingATabPage );
                        tabControl.TabPages.Insert( 1, buildingCTabPage );
                        tabControl.SelectTab( buildingCTabPage );
                        buildingCListBox.Items.Clear();

                        foreach( var c in TenantBuildingForm.buildingTasks )
                        {
                            buildingsC.Add( c );

                            string buildingName = c.GetTaskInfo().Trim().Split().Last();
                            if( buildingName == "C" )
                            {
                                buildingCListBox.Items.Add( c.GetTaskInfo() );
                            }
                        }
                    }
                    else
                    {
                        tabControl.SelectTab( buildingCTabPage );
                    }
                    break;
                default:
                    item = 0;
                    break;
            }
        }

        /**
         * Method to show all tasks for Building A
         */
        private void showAllTasksAButton_Click( object sender, EventArgs e )
        {
            buildingAListBox.Items.Clear();

            if(buildingsA.Count != 0)
            {
                foreach( TaskClass a in buildingsA )
                {
                    if( a.Time == "Unknown" )
                    {
                        //buildingAListBox.Items.Clear();
                    }
                    else
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split().Last();

                        if( buildingName == "A" )
                        {
                            buildingAListBox.Items.Add( a.ToString() );
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no tasks. Please contact management!" );
            }
        }

        /**
         * Method to show all tasks for Building B
         */
        private void showAllTasksBButton_Click( object sender, EventArgs e )
        {
            buildingBListBox.Items.Clear();

            if( buildingsB.Count != 0 )
            {
                foreach( TaskClass b in buildingsB )
                {
                    if( b.Time == "Unknown" )
                    {
                        //buildingBListBox.Items.Clear();
                    }
                    else
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();

                        if( buildingName == "B" )
                        {
                            buildingBListBox.Items.Add( b.GetTaskInfo() );
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no tasks. Please contact management!" );
            }
        }

        /**
         * Method to show all tasks for Building C
         */
        private void showAllTasksCButton_Click( object sender, EventArgs e )
        {
            buildingCListBox.Items.Clear();

            if( buildingsC.Count != 0 )
            {
                foreach( TaskClass c in buildingsC )
                {
                    if( c.Time == "Unknown" )
                    {
                        //buildingCListBox.Items.Clear();
                    }
                    else
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();

                        if( buildingName == "C" )
                        {
                            buildingCListBox.Items.Add( c.GetTaskInfo() );
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no tasks. Please contact management!" );
            }
        }

        /**
         * Method to show a specific task based on the hour for Building A
         */
        private void showTimeSpecificTaskAButton_Click( object sender, EventArgs e )
        {
            if( timeAComboBox.SelectedItem == null )
            {
                MessageBox.Show( "Please select an hour." );
            }
            else
            {
                buildingATimeListBox.Items.Clear();

                if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Monday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Tuesday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Wednesday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Thursday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Friday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday )
                {
                    foreach( var a in buildingsA )
                    {
                        string buildingName = a.GetTaskInfo().Trim().Split( ' ' ).LastOrDefault();
                        string dayTime = timeAComboBox.SelectedItem.ToString();

                        if( buildingName == "A" )
                        {
                            if( dayTime == a.Time )
                            {
                                buildingATimeListBox.Items.Add( a );
                            }
                        }
                    }
                }
            }
        }

        /**
         * Method to show a specific task based on the hour for Building B
         */
        private void showTimeSpecificTaskBButton_Click( object sender, EventArgs e )
        {
            if( timeBComboBox.SelectedItem == null )
            {
                MessageBox.Show( "Please select an hour." );
            }
            else
            {
                buildingBTimeListBox.Items.Clear();

                if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Monday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Tuesday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Wednesday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Thursday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Friday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday )
                {
                    foreach( var b in buildingsB )
                    {
                        string buildingName = b.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeBComboBox.SelectedItem.ToString();

                        if( buildingName == "B" )
                        {
                            if( dayTime == b.Time )
                            {
                                buildingBTimeListBox.Items.Add( b );
                            }
                        }
                    }
                }
            }
        }

        /**
         * Method to show a specific task based on the hour for Building C
         */
        private void showTimeSpecificTaskCButton_Click( object sender, EventArgs e )
        {
            if( timeCComboBox.SelectedItem == null )
            {
                MessageBox.Show( "Please select an hour." );
            }
            else
            {
                buildingCTimeListBox.Items.Clear();

                if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Monday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Tuesday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Wednesday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Thursday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Friday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
                else if( calendarADateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday )
                {
                    foreach( var c in buildingsC )
                    {
                        string buildingName = c.GetTaskInfo().Trim().Split().Last();
                        string dayTime = timeCComboBox.SelectedItem.ToString();

                        if( buildingName == "C" )
                        {
                            if( dayTime == c.Time )
                            {
                                buildingCTimeListBox.Items.Add( c );
                            }
                        }
                    }
                }
            }
        }

        /**
         * Method to show all students from Building A without a task
         */
        private void showStudentsAWithoutTaskButton_Click( object sender, EventArgs e )
        {
            buildingATimeListBox.Items.Clear();

            if( buildingsA.Count != 0 )
            {
                foreach( TaskClass task in buildingsA )
                {
                    if( task.Time == "Unknown" )
                    {
                        buildingATimeListBox.Items.Add( task.GetTaskInfo() );
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no students without a task!" );
            }
        }

        /**
         * Method to show all students from Building B without a task
         */
        private void showStudentsBWithoutTaskButton_Click( object sender, EventArgs e )
        {
            buildingBTimeListBox.Items.Clear();

            if( buildingsB.Count != 0 )
            {
                foreach( TaskClass task in buildingsB )
                {
                    if( task.Time == "Unknown" )
                    {
                        buildingBTimeListBox.Items.Add( task.GetTaskInfo() );
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no students without a task!" );
            }
        }

        /**
         * Method to show all students from Building C without a task
         */
        private void showStudentsCWithoutTaskButton_Click( object sender, EventArgs e )
        {
            buildingCTimeListBox.Items.Clear();

            if( buildingsC.Count != 0 )
            {
                foreach( TaskClass task in buildingsC )
                {
                    if( task.Time == "Unknown" )
                    {
                        buildingCTimeListBox.Items.Add( task.GetTaskInfo() );
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no students without a task!" );
            }
        }

        /**
         * Method to assign a task to a student from Building A
         */
        private void assignATaskButton_Click( object sender, EventArgs e )
        {
            FacilityClass facility = ( FacilityClass ) facilityAComboBox.SelectedItem;
            string hour = taskTimeAComboBox.SelectedItem.ToString();

            if( buildingATimeListBox.SelectedIndex != -1 )
            {
                foreach( TaskClass task in buildingsA.ToList() )
                {
                    //check
                    if( (task.Time == "Unknown") && ( buildingATimeListBox.SelectedIndex == 0) )
                    {

                        task.Time = hour;
                        task.FacilityName = facility.ToString();
                        buildingATimeListBox.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show( "Please select a student first!" );
            }
        }

        /**
         * Method to assign a task to a student from Building B
         */
        private void assignBTaskButton_Click( object sender, EventArgs e )
        {
            FacilityClass facility = ( FacilityClass ) facilityBComboBox.SelectedItem;
            string hour = taskTimeBComboBox.SelectedItem.ToString();

            if( buildingBTimeListBox.SelectedIndex != -1 )
            {
                foreach( TaskClass task in buildingsB.ToList() )
                {
                    if( ( task.Time == "Unknown" ) && ( buildingBTimeListBox.SelectedIndex == 0 ) )
                    {
                        task.Time = hour;
                        task.FacilityName = facility.ToString();
                        buildingBTimeListBox.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show( "Please select a student first!" );
            }
        }

        /**
         * Method to assign a task to a student from Building C
         */
        private void assignCTaskButton_Click( object sender, EventArgs e )
        {
            FacilityClass facility = ( FacilityClass ) facilityCComboBox.SelectedItem;
            string hour = taskTimeCComboBox.SelectedItem.ToString();

            if( buildingCTimeListBox.SelectedIndex != -1 )
            {
                foreach( TaskClass task in buildingsC.ToList() )
                {
                    if( ( task.Time == "Unknown" ) && ( buildingCTimeListBox.SelectedIndex == 0 ) )
                    {
                        task.Time = hour;
                        task.FacilityName = facility.ToString();
                        buildingCTimeListBox.Items.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show( "Please select a student first!" );
            }
        }

        /**
         * Method to add a rule to the listbox and add rule to rules list to send to the tenant form
         */
        private void addRuleButton_Click( object sender, EventArgs e )
        {
            if( ruleTextBox.Text != null )
            {
                rulesListBox.Items.Add( ruleTextBox.Text + "-" + now );
            }
            else
            {
                MessageBox.Show( "Type a rule first" );
            }

            foreach( String rule in rulesListBox.Items )
            {
                rules.Add( rule );
            }
        }

        /**
         * Method to remove a rule
         */
        private void removeRuleButton_Click( object sender, EventArgs e )
        {
            if( rulesListBox.SelectedIndex != -1 )
            {
                for( int i = rulesListBox.SelectedItems.Count - 1; i >= 0; i-- )
                {
                    rulesListBox.Items.Remove( rulesListBox.SelectedItems[ i ] );
                }
            }
            else
            {
                MessageBox.Show( "Select a rule first" );
            }
        }

        /**
         * Method to log out 
         */
        private void logoutButton_Click( object sender, EventArgs e )
        {
            LoginForm loginForm = new LoginForm();
            DialogResult dialogResult = MessageBox.Show( "Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo );

            if( dialogResult == DialogResult.Yes )
            {
                this.Hide();
                loginForm.Show();
            }
            else if( dialogResult == DialogResult.No )
            {
                this.Show();
            }
        }
    }
}
