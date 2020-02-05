using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentHousingBv
{
    public partial class LoginForm : Form
    {
        public static int studentCode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                StudentClass student = new StudentClass();
                LandLordClass landLord = new LandLordClass();
                LandlordBuildingForm bform = new LandlordBuildingForm();
                TenantBuildingForm sbform = new TenantBuildingForm();
                int landLordCode = landLord.GetLoginCode();
                int password = Convert.ToInt32( loginCodeTextBox.Text );

                if( landLordCode == Convert.ToInt32( loginCodeTextBox.Text ) )
                {
                    this.Hide();
                    bform.Show();
                }
                else if( ( password == student.GetLoginCodeBuildingA() ) || ( password == student.GetLoginCodeBuildingB() ) || ( password == student.GetLoginCodeBuildingC() ) )
                {
                    studentCode = password;
                    this.Hide();
                    sbform.Show();
                }
                else
                {
                    MessageBox.Show( "Please enter the correct password!" );
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show( "Please enter numbers only!" );
            }
        }
    }
}
