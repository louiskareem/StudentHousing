using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Globalization;


namespace studentHousingBv
{
    public partial class TenantBuildingForm : Form
    {
        WebSocket ws;
        Grocery grocery = new Grocery();
        BuildingClass buildingA = new BuildingClass();
        BuildingClass buildingB = new BuildingClass();
        BuildingClass buildingC = new BuildingClass();
        public static List<TaskClass> buildingTasks = new List<TaskClass>();
        public static List<TaskClass> doneTasks = new List<TaskClass>();
        public static List<String> complaints = new List<string>();
        List<string> groceries = new List<string>();
        DateTime now = DateTime.Now;

        /**
         * Constructor
         */
        public TenantBuildingForm()
        {
            InitializeComponent();
            //ws = new WebSocket();
            timer1.Start();
            DateTime time = DateTime.Today;

            for( DateTime _time = time.AddHours( 08 ); _time < time.AddHours( 24 ); _time = _time.AddMinutes( 60 ) ) //from 16h to 18h hours
            {
                timeComboBox.Items.Add( _time.ToShortTimeString() );
            }

            buildingA.AddTasksToBuilding( "8:00 AM", "Chris", "Groceries", "A" );
            buildingA.AddTasksToBuilding( "9:00 AM", "Rihanna", "Kitchen", "A" );
            buildingA.AddTasksToBuilding( "10:00 AM", "Hoffa", "Pool", "A" );
            buildingA.AddTasksToBuilding( "12:00 PM", "Jabba", "Hallway", "A" );
            buildingA.AddTasksToBuilding( "12:00 PM", "James", "Toilet", "A" );
            buildingA.AddTasksToBuilding( "12:00 PM", "Mike", "Garbage", "A" );
            buildingA.AddTasksToBuilding( "3:00 PM", "Katalina", "Storage Space", "A" );

            buildingB.AddTasksToBuilding( "8:00 AM", "Louis", "Gym", "B" );
            buildingB.AddTasksToBuilding( "9:00 AM", "Katrina", "Kitchen", "B" );
            buildingB.AddTasksToBuilding( "10:00 AM", "Mekka", "Pool", "B" );
            buildingB.AddTasksToBuilding( "11:00 AM", "Louis", "Theather", "B" );
            buildingB.AddTasksToBuilding( "12:00 PM", "Jordan", "Storage Space", "B" );
            buildingB.AddTasksToBuilding( "1:00 PM", "Katrina", "Groceries", "B" );
            buildingB.AddTasksToBuilding( "4:00 PM", "Mekka", "Garbage", "B" );

            buildingC.AddTasksToBuilding( "8:00 AM", "Justin", "Gym", "C" );
            buildingC.AddTasksToBuilding( "9:00 AM", "Drake", "Kitchen", "C" );
            buildingC.AddTasksToBuilding( "10:00 AM", "Jimmy", "Groceries", "C" );
            buildingC.AddTasksToBuilding( "12:00 PM", "Derrick", "Hallway", "C" );
            buildingC.AddTasksToBuilding( "1:00 PM", "Justin", "Pool", "C" );
            buildingC.AddTasksToBuilding( "3:00 PM", "Drake", "Garbage", "C" );

            buildingTasks.AddRange( buildingA.GetTasks() );
            buildingTasks.AddRange( buildingB.GetTasks() );
            buildingTasks.AddRange( buildingC.GetTasks() );

            complaintsListBox.Items.Add( "The pool has been dirty for a week :(" + "-" + now );
            complaintsListBox.Items.Add( "OMG! Someone organized a party without saying anything to us!!!" + "-" + now );
            complaintsListBox.Items.Add( "Chris did not do the groceries." + "-" + now );
            complaintsListBox.Items.Add( "There's too many bikes in the storage room!!!" );
            complaintsListBox.Items.Add( "I would like to suggest a new rule. No smoking in the room :)" + "-" + now );
        }

        /*
         * Method to send a complaint to the landlord page via the websocket connection
         * And add complaint to the listbox at the same time
         */
        private void submitComplaintButton_Click( object sender, EventArgs e )
        {
            if( complaintTextBox.Text != null )
            {
                complaintsListBox.Items.Add( complaintTextBox.Text + "-" + now );
            }
            else
            {
                MessageBox.Show( "Type a rule first" );
            }

            foreach( String complaint in complaintsListBox.Items )
            {
                complaints.Add( complaint );
            }
        }

        /*
         * Method to remove a complaint from the listbox
         */
        private void removeComplaintButton_Click( object sender, EventArgs e )
        {
            if( complaintsListBox.SelectedIndex != -1 )
            {
                for( int i = complaintsListBox.SelectedItems.Count - 1; i >= 0; i-- )
                {
                    complaintsListBox.Items.Remove( complaintsListBox.SelectedItems[ i ] );
                }
            }
        }

        /*
         * Method to run when user clicks on show all tasks
         * The data for the task are automatically created when user logs in
         *
         */
        private void showAllTasksButton_Click( object sender, EventArgs e )
        {
            calendarCheckedListBox.Items.Clear();

            if((buildingA.GetTasks().Count != 0) || ( buildingB.GetTasks().Count != 0 ) || ( buildingC.GetTasks().Count != 0 ) )
            {
                if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Monday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Tuesday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Wednesday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Thursday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }

                            foreach( TaskClass unassigned in LandlordBuildingForm.unassignedTasks )
                            {
                                calendarCheckedListBox.Items.Add( unassigned );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Friday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( var a in buildingA.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( a );
                            }
                            break;
                        case 4321:
                            foreach( var b in buildingB.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( b );
                            }
                            break;
                        case 2468:
                            foreach( var c in buildingC.GetTasks() )
                            {
                                calendarCheckedListBox.Items.Add( c );
                            }
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no available tasks. Please contact management!" );
            }
        }

        /**
         *  Method to show data based on the selected time from the dropdown list
         *
         */
        private void showTimeSpecificTaskButton_Click( object sender, EventArgs e )
        {
            calendarListBox.Items.Clear();

            if( timeComboBox.SelectedItem == null )
            {
                MessageBox.Show( "Please select an hour." );
            }
            else
            {
                if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Monday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Tuesday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Wednesday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();

                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Thursday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Friday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
                else if( calendarDateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday )
                {
                    int code = LoginForm.studentCode;

                    switch( code )
                    {
                        case 1234:
                            foreach( TaskClass a in buildingA.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == a.Time )
                                {
                                    calendarListBox.Items.Add( a );
                                }
                            }
                            break;
                        case 4321:
                            foreach( TaskClass b in buildingB.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == b.Time )
                                {
                                    calendarListBox.Items.Add( b );
                                }
                            }
                            break;
                        case 2468:
                            foreach( TaskClass c in buildingC.GetTasks() )
                            {
                                string dayTime = timeComboBox.SelectedItem.ToString();
                                if( dayTime == c.Time )
                                {
                                    calendarListBox.Items.Add( c );
                                }
                            }
                            break;
                    }
                }
            }
        }

        /**
         *  Method to send complaints to the landlord every day at a specific hour of the day
         */
        private void sendMailButton_Click( object sender, EventArgs e )
        {
            MailForm mailForm = new MailForm();
            mailForm.Show();

            //var message = new MimeMessage();
            //message.From.Add( new MailboxAddress( "Louis", "440569@student.fontys.nl" ) );
            //message.To.Add( new MailboxAddress( "LC", "louiskareemcocks@hotmail.com" ) );
            //message.Subject = "Daily StudentHousing BV";

            //string[] array = new string[ doneTasks.Count ];
            //for( int i = 1; i < doneTasks.Count; i++ )
            //{
            //    array[ i ] = doneTasks[ i ].ToString() + " is done. ";
            //}
            //string result = string.Join( "\n", array );

            //message.Body = new TextPart( "plain" )
            //{
            //    Text = @"Your daily report of all the chores that are completed!" + "\n" + result
            //};

            //using( var client = new SmtpClient() )
            //{
            //    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
            //    //client.ServerCertificateValidationCallback = ( s, c, h, error ) => true;

            //    client.Connect( "smtp.office365.com", 587, false);

            //    // Note: only needed if the SMTP server requires authentication
            //    client.Authenticate( "440569@student.fontys.nl", "Gonkmengveu7" ); //

            //    client.Send( message );
            //    client.Disconnect( true );
            //}
        }

        /**
         * Method to run when user clicks on task is done.
         * Loop through the items in the check listbox
         * then check if the time (item) is equal to the time selected from the hours combobox
         * If so, then add the done task to the calendar listbox and change color of the item
         */
        private void taskDoneButton_Click( object sender, EventArgs e )
        {
            if( timeComboBox.SelectedItem == null )
            {
                MessageBox.Show( "Please select an hour." );
            }
            else
            {
                string dayTime = timeComboBox.SelectedItem.ToString();
                calendarListBox.Items.Clear();

                foreach( TaskClass item in calendarCheckedListBox.CheckedItems )
                {
                    if( item.Time == dayTime )
                    {
                        calendarListBox.Items.Add( item + " is done." );
                        calendarListBox.ForeColor = Color.Crimson;
                        calendarCheckedListBox.ForeColor = Color.Blue;
                        doneTasks.Add( item );
                    }
                }
            }
        }

        /**
         * Timer method that runs periodically. Something like a cronjobs
         */
        private void timer1_Tick( object sender, EventArgs e )
        {
            //DateTime nowTime = DateTime.Now;
            //DateTime scheduledTime = new DateTime( nowTime.Year, nowTime.Month, nowTime.Day, 8, 42, 0, 0 ); //Specify your scheduled time HH,MM,SS [8am and 42 minutes]

            //if(nowTime > scheduledTime)
            //{
            //    MessageBox.Show( "The timer is ticking" );
            //}

            //rulesListBox.Items.Clear();

            foreach( String rule in LandlordBuildingForm.rules )
            {
                if( !rulesListBox.Items.Contains( rule ) )
                {
                    rulesListBox.Items.Add( rule );
                }
            }
        }

        /**
         * Method to show the euro sign
         */
        public static char HexToChar( string hex )
        {
            return ( char ) ushort.Parse( hex, System.Globalization.NumberStyles.HexNumber );
        }

        /**
         * Method to calculate and divide the costs for groceries
         */
        private void payGroceriesButton_Click( object sender, EventArgs e )
        {
            try
            {
                // Variables
                string studentName = studentNameTextBox.Text;
                double totalCost = Convert.ToDouble( groceriesTotalCostTextBox.Text );
                groceries.Add( studentName + " " + HexToChar( "20AC" ) + " " + totalCost );
                List<String> students = new List<String>();

                foreach( TaskClass task in buildingA.GetTasks() )
                {
                    if( studentName != task.StudentName )
                    {
                        students.Add( task.StudentName );
                        owedGroceriesListBox.Items.Add( task.StudentName );
                    }
                }

                int count = Convert.ToInt32( owedGroceriesListBox.Items.Count + 1 );
                grocery.CalculateAmount( totalCost, count );

                for( int i = 0; i < students.Count; i++ )
                {
                    string student = students[ i ];
                    if( owedGroceriesListBox.Items.Contains( student ) )
                    {
                        owedGroceriesListBox.Items.Remove( student );
                    }

                    if( students.Contains( student ) )
                    {
                        owedGroceriesListBox.Items.Add( student + " - " + " Owes " + studentName + " : " + grocery.GetAmountInfo() );
                    }
                }

                foreach( string g in groceries )
                {
                    groceriesListBox.Items.Add( g );
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show( "Please enter numbers only!" );
            }
        }

        /**
         * Method to show all completed tasks
         */
        private void showAllCompletedTasksButton_Click( object sender, EventArgs e )
        {
            calendarListBox.Items.Clear();

            if(doneTasks.Count != 0)
            {
                foreach( TaskClass task in doneTasks )
                {
                    if(!calendarListBox.Items.Contains(task))
                    {
                        calendarListBox.Items.Add( task.GetTaskInfo() );
                    }
                }
            }
            else
            {
                MessageBox.Show( "There are no completed tasks!" );
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

        /**
         * Method to clear the results on screen
         */
        private void clearResultsButton_Click( object sender, EventArgs e )
        {
            groceriesListBox.Items.Clear();
            owedGroceriesListBox.Items.Clear();
            studentNameTextBox.Text = "";
            groceriesTotalCostTextBox.Text = "";
        }
    }
}