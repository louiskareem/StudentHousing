using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
            timer2.Start();
        }

        private void sendEmailButton_Click( object sender, EventArgs e )
        {
            String to = receiverEmailTextBox.Text;
            String from = senderEmailTextBox.Text;
            String password = senderPassword.Text;
            String body = emailBodyTextBox.Text;

            if( !string.IsNullOrWhiteSpace(body))
            {
                var message = new MimeMessage();
                message.From.Add( new MailboxAddress( from ) );
                message.To.Add( new MailboxAddress( to ) );
                message.Subject = "Daily StudentHousing BV";

                message.Body = new TextPart( "plain" )
                {
                    Text = body
                };

                using( var client = new SmtpClient() )
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    //client.ServerCertificateValidationCallback = ( s, c, h, error ) => true;

                    client.Connect( "smtp.office365.com", 587, false );

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate( from, password ); //

                    client.Send( message );
                    client.Disconnect( true );
                }
            }
            else
            {
                MessageBox.Show( "The email body is empty!" );
            }
        }

        private void sendDailyReportButton_Click( object sender, EventArgs e )
        {
            String to = receiverEmailTextBox.Text;
            String from = senderEmailTextBox.Text;
            String password = senderPassword.Text;
            String body = emailBodyTextBox.Text;

            if( Control.IsKeyLocked( Keys.CapsLock ) )
            {
                MessageBox.Show( "The Caps Lock key is ON." );
            }

            if(TenantBuildingForm.doneTasks.Count != 0)
            {
                var message = new MimeMessage();
                message.From.Add( new MailboxAddress( from ) );
                message.To.Add( new MailboxAddress( to ) );
                message.Subject = "Daily StudentHousing BV";

                string[] array = new string[ TenantBuildingForm.doneTasks.Count ];
                for( int i = 1; i < TenantBuildingForm.doneTasks.Count; i++ )
                {
                    array[ i ] = TenantBuildingForm.doneTasks[ i ].ToString() + " is done. ";
                }
                string result = string.Join( "\n", array );

                message.Body = new TextPart( "plain" )
                {
                    Text = @"Your daily report of all the chores that are completed!" + "\n" + result
                };

                using( var client = new SmtpClient() )
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    //client.ServerCertificateValidationCallback = ( s, c, h, error ) => true;

                    client.Connect( "smtp.office365.com", 587, false );

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate( from, password ); //

                    client.Send( message );
                    client.Disconnect( true );
                }
            }
            else
            {
                MessageBox.Show( "There are no completed tasks!" );
            }
        }

        private void cancelEmailButton_Click( object sender, EventArgs e )
        {
            DialogResult dialogResult = MessageBox.Show( "Are you sure you want cancel?", "Logging out", MessageBoxButtons.YesNo );

            if( dialogResult == DialogResult.Yes )
            {
                this.Hide();
            }
            else if( dialogResult == DialogResult.No )
            {
                this.Show();
            }
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            if( Control.IsKeyLocked( Keys.CapsLock ) )
            {
                MessageBox.Show( "The Caps Lock key is ON." );
            }
        }

        private void timer2_Tick( object sender, EventArgs e )
        {
            senderPassword.PasswordChar = '*';
        }
    }
}
