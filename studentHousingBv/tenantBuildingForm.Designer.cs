namespace studentHousingBv
{
    partial class TenantBuildingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.calendarTabPage = new System.Windows.Forms.TabPage();
            this.logoutButton = new System.Windows.Forms.Button();
            this.showAllCompletedTasksButton = new System.Windows.Forms.Button();
            this.taskDoneButton = new System.Windows.Forms.Button();
            this.calendarCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.showAllTasksButton = new System.Windows.Forms.Button();
            this.showTimeSpecificTaskButton = new System.Windows.Forms.Button();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.calendarListBox = new System.Windows.Forms.ListBox();
            this.calendarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groceriesTabPage = new System.Windows.Forms.TabPage();
            this.payGroceriesButton = new System.Windows.Forms.Button();
            this.groceriesTotalCostLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.groceriesTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.owedGroceriesListBox = new System.Windows.Forms.ListBox();
            this.groceriesListBox = new System.Windows.Forms.ListBox();
            this.rulesTabPage = new System.Windows.Forms.TabPage();
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.complaintsTabPage = new System.Windows.Forms.TabPage();
            this.complaintTextBox = new System.Windows.Forms.TextBox();
            this.removeComplaintButton = new System.Windows.Forms.Button();
            this.submitComplaintButton = new System.Windows.Forms.Button();
            this.complaintsListBox = new System.Windows.Forms.ListBox();
            this.btnViewRulesTenant = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clearResultsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.calendarTabPage.SuspendLayout();
            this.groceriesTabPage.SuspendLayout();
            this.rulesTabPage.SuspendLayout();
            this.complaintsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.calendarTabPage);
            this.tabControl1.Controls.Add(this.groceriesTabPage);
            this.tabControl1.Controls.Add(this.rulesTabPage);
            this.tabControl1.Controls.Add(this.complaintsTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1314, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // calendarTabPage
            // 
            this.calendarTabPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.calendarTabPage.Controls.Add(this.logoutButton);
            this.calendarTabPage.Controls.Add(this.showAllCompletedTasksButton);
            this.calendarTabPage.Controls.Add(this.taskDoneButton);
            this.calendarTabPage.Controls.Add(this.calendarCheckedListBox);
            this.calendarTabPage.Controls.Add(this.sendMailButton);
            this.calendarTabPage.Controls.Add(this.showAllTasksButton);
            this.calendarTabPage.Controls.Add(this.showTimeSpecificTaskButton);
            this.calendarTabPage.Controls.Add(this.timeComboBox);
            this.calendarTabPage.Controls.Add(this.calendarListBox);
            this.calendarTabPage.Controls.Add(this.calendarDateTimePicker);
            this.calendarTabPage.Location = new System.Drawing.Point(4, 32);
            this.calendarTabPage.Name = "calendarTabPage";
            this.calendarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.calendarTabPage.Size = new System.Drawing.Size(1306, 692);
            this.calendarTabPage.TabIndex = 0;
            this.calendarTabPage.Text = "Calendar";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.LightCoral;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1102, 625);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(187, 44);
            this.logoutButton.TabIndex = 22;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showAllCompletedTasksButton
            // 
            this.showAllCompletedTasksButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllCompletedTasksButton.Location = new System.Drawing.Point(792, 466);
            this.showAllCompletedTasksButton.Name = "showAllCompletedTasksButton";
            this.showAllCompletedTasksButton.Size = new System.Drawing.Size(399, 39);
            this.showAllCompletedTasksButton.TabIndex = 21;
            this.showAllCompletedTasksButton.Text = "Show All Completed Tasks";
            this.showAllCompletedTasksButton.UseVisualStyleBackColor = true;
            this.showAllCompletedTasksButton.Click += new System.EventHandler(this.showAllCompletedTasksButton_Click);
            // 
            // taskDoneButton
            // 
            this.taskDoneButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.taskDoneButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDoneButton.Location = new System.Drawing.Point(17, 635);
            this.taskDoneButton.Name = "taskDoneButton";
            this.taskDoneButton.Size = new System.Drawing.Size(308, 34);
            this.taskDoneButton.TabIndex = 20;
            this.taskDoneButton.Text = "Task Is Done";
            this.taskDoneButton.UseVisualStyleBackColor = false;
            this.taskDoneButton.Click += new System.EventHandler(this.taskDoneButton_Click);
            // 
            // calendarCheckedListBox
            // 
            this.calendarCheckedListBox.CheckOnClick = true;
            this.calendarCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarCheckedListBox.FormattingEnabled = true;
            this.calendarCheckedListBox.Location = new System.Drawing.Point(17, 15);
            this.calendarCheckedListBox.Name = "calendarCheckedListBox";
            this.calendarCheckedListBox.Size = new System.Drawing.Size(635, 436);
            this.calendarCheckedListBox.TabIndex = 19;
            // 
            // sendMailButton
            // 
            this.sendMailButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMailButton.Location = new System.Drawing.Point(792, 511);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(399, 44);
            this.sendMailButton.TabIndex = 18;
            this.sendMailButton.Text = "Send Email To LandLord";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // showAllTasksButton
            // 
            this.showAllTasksButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.showAllTasksButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllTasksButton.Location = new System.Drawing.Point(17, 590);
            this.showAllTasksButton.Name = "showAllTasksButton";
            this.showAllTasksButton.Size = new System.Drawing.Size(308, 39);
            this.showAllTasksButton.TabIndex = 9;
            this.showAllTasksButton.Text = "Show All Tasks";
            this.showAllTasksButton.UseVisualStyleBackColor = false;
            this.showAllTasksButton.Click += new System.EventHandler(this.showAllTasksButton_Click);
            // 
            // showTimeSpecificTaskButton
            // 
            this.showTimeSpecificTaskButton.BackColor = System.Drawing.Color.SteelBlue;
            this.showTimeSpecificTaskButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeSpecificTaskButton.Location = new System.Drawing.Point(17, 538);
            this.showTimeSpecificTaskButton.Name = "showTimeSpecificTaskButton";
            this.showTimeSpecificTaskButton.Size = new System.Drawing.Size(308, 46);
            this.showTimeSpecificTaskButton.TabIndex = 8;
            this.showTimeSpecificTaskButton.Text = "Show Time-Specified Task";
            this.showTimeSpecificTaskButton.UseVisualStyleBackColor = false;
            this.showTimeSpecificTaskButton.Click += new System.EventHandler(this.showTimeSpecificTaskButton_Click);
            // 
            // timeComboBox
            // 
            this.timeComboBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(17, 503);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(308, 29);
            this.timeComboBox.TabIndex = 7;
            this.timeComboBox.Text = "Select An Hour";
            // 
            // calendarListBox
            // 
            this.calendarListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarListBox.FormattingEnabled = true;
            this.calendarListBox.ItemHeight = 23;
            this.calendarListBox.Location = new System.Drawing.Point(671, 15);
            this.calendarListBox.Name = "calendarListBox";
            this.calendarListBox.Size = new System.Drawing.Size(618, 441);
            this.calendarListBox.TabIndex = 3;
            // 
            // calendarDateTimePicker
            // 
            this.calendarDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarDateTimePicker.Location = new System.Drawing.Point(17, 469);
            this.calendarDateTimePicker.Name = "calendarDateTimePicker";
            this.calendarDateTimePicker.Size = new System.Drawing.Size(308, 28);
            this.calendarDateTimePicker.TabIndex = 2;
            // 
            // groceriesTabPage
            // 
            this.groceriesTabPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groceriesTabPage.Controls.Add(this.clearResultsButton);
            this.groceriesTabPage.Controls.Add(this.payGroceriesButton);
            this.groceriesTabPage.Controls.Add(this.groceriesTotalCostLabel);
            this.groceriesTabPage.Controls.Add(this.studentNameLabel);
            this.groceriesTabPage.Controls.Add(this.groceriesTotalCostTextBox);
            this.groceriesTabPage.Controls.Add(this.studentNameTextBox);
            this.groceriesTabPage.Controls.Add(this.owedGroceriesListBox);
            this.groceriesTabPage.Controls.Add(this.groceriesListBox);
            this.groceriesTabPage.Location = new System.Drawing.Point(4, 32);
            this.groceriesTabPage.Name = "groceriesTabPage";
            this.groceriesTabPage.Size = new System.Drawing.Size(1306, 692);
            this.groceriesTabPage.TabIndex = 3;
            this.groceriesTabPage.Text = "Groceries";
            // 
            // payGroceriesButton
            // 
            this.payGroceriesButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.payGroceriesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payGroceriesButton.Location = new System.Drawing.Point(158, 517);
            this.payGroceriesButton.Name = "payGroceriesButton";
            this.payGroceriesButton.Size = new System.Drawing.Size(263, 45);
            this.payGroceriesButton.TabIndex = 6;
            this.payGroceriesButton.Text = "Calculate Groceries";
            this.payGroceriesButton.UseVisualStyleBackColor = false;
            this.payGroceriesButton.Click += new System.EventHandler(this.payGroceriesButton_Click);
            // 
            // groceriesTotalCostLabel
            // 
            this.groceriesTotalCostLabel.AutoSize = true;
            this.groceriesTotalCostLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceriesTotalCostLabel.Location = new System.Drawing.Point(22, 464);
            this.groceriesTotalCostLabel.Name = "groceriesTotalCostLabel";
            this.groceriesTotalCostLabel.Size = new System.Drawing.Size(117, 23);
            this.groceriesTotalCostLabel.TabIndex = 5;
            this.groceriesTotalCostLabel.Text = "Total costs:";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(63, 412);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(76, 23);
            this.studentNameLabel.TabIndex = 4;
            this.studentNameLabel.Text = "Name:";
            // 
            // groceriesTotalCostTextBox
            // 
            this.groceriesTotalCostTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceriesTotalCostTextBox.Location = new System.Drawing.Point(158, 461);
            this.groceriesTotalCostTextBox.Name = "groceriesTotalCostTextBox";
            this.groceriesTotalCostTextBox.Size = new System.Drawing.Size(263, 32);
            this.groceriesTotalCostTextBox.TabIndex = 3;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(158, 409);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(263, 32);
            this.studentNameTextBox.TabIndex = 2;
            // 
            // owedGroceriesListBox
            // 
            this.owedGroceriesListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owedGroceriesListBox.FormattingEnabled = true;
            this.owedGroceriesListBox.ItemHeight = 23;
            this.owedGroceriesListBox.Location = new System.Drawing.Point(663, 3);
            this.owedGroceriesListBox.Name = "owedGroceriesListBox";
            this.owedGroceriesListBox.Size = new System.Drawing.Size(640, 372);
            this.owedGroceriesListBox.TabIndex = 1;
            // 
            // groceriesListBox
            // 
            this.groceriesListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceriesListBox.FormattingEnabled = true;
            this.groceriesListBox.ItemHeight = 23;
            this.groceriesListBox.Location = new System.Drawing.Point(3, 3);
            this.groceriesListBox.Name = "groceriesListBox";
            this.groceriesListBox.Size = new System.Drawing.Size(638, 372);
            this.groceriesListBox.TabIndex = 0;
            // 
            // rulesTabPage
            // 
            this.rulesTabPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rulesTabPage.Controls.Add(this.rulesListBox);
            this.rulesTabPage.Location = new System.Drawing.Point(4, 32);
            this.rulesTabPage.Name = "rulesTabPage";
            this.rulesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rulesTabPage.Size = new System.Drawing.Size(1306, 692);
            this.rulesTabPage.TabIndex = 1;
            this.rulesTabPage.Text = "Rules";
            // 
            // rulesListBox
            // 
            this.rulesListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.ItemHeight = 23;
            this.rulesListBox.Location = new System.Drawing.Point(18, 27);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(1269, 625);
            this.rulesListBox.TabIndex = 0;
            // 
            // complaintsTabPage
            // 
            this.complaintsTabPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.complaintsTabPage.Controls.Add(this.complaintTextBox);
            this.complaintsTabPage.Controls.Add(this.removeComplaintButton);
            this.complaintsTabPage.Controls.Add(this.submitComplaintButton);
            this.complaintsTabPage.Controls.Add(this.complaintsListBox);
            this.complaintsTabPage.Location = new System.Drawing.Point(4, 32);
            this.complaintsTabPage.Name = "complaintsTabPage";
            this.complaintsTabPage.Size = new System.Drawing.Size(1306, 692);
            this.complaintsTabPage.TabIndex = 2;
            this.complaintsTabPage.Text = "Complaints";
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintTextBox.Location = new System.Drawing.Point(765, 19);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.Size = new System.Drawing.Size(525, 533);
            this.complaintTextBox.TabIndex = 3;
            this.complaintTextBox.Text = "Enter complaint here...";
            // 
            // removeComplaintButton
            // 
            this.removeComplaintButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeComplaintButton.Location = new System.Drawing.Point(307, 597);
            this.removeComplaintButton.Name = "removeComplaintButton";
            this.removeComplaintButton.Size = new System.Drawing.Size(147, 47);
            this.removeComplaintButton.TabIndex = 2;
            this.removeComplaintButton.Text = "Remove";
            this.removeComplaintButton.UseVisualStyleBackColor = true;
            this.removeComplaintButton.Click += new System.EventHandler(this.removeComplaintButton_Click);
            // 
            // submitComplaintButton
            // 
            this.submitComplaintButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitComplaintButton.Location = new System.Drawing.Point(949, 597);
            this.submitComplaintButton.Name = "submitComplaintButton";
            this.submitComplaintButton.Size = new System.Drawing.Size(147, 47);
            this.submitComplaintButton.TabIndex = 1;
            this.submitComplaintButton.Text = "Submit";
            this.submitComplaintButton.UseVisualStyleBackColor = true;
            this.submitComplaintButton.Click += new System.EventHandler(this.submitComplaintButton_Click);
            // 
            // complaintsListBox
            // 
            this.complaintsListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintsListBox.FormattingEnabled = true;
            this.complaintsListBox.ItemHeight = 23;
            this.complaintsListBox.Location = new System.Drawing.Point(15, 19);
            this.complaintsListBox.Name = "complaintsListBox";
            this.complaintsListBox.Size = new System.Drawing.Size(724, 533);
            this.complaintsListBox.TabIndex = 0;
            // 
            // btnViewRulesTenant
            // 
            this.btnViewRulesTenant.Location = new System.Drawing.Point(723, 274);
            this.btnViewRulesTenant.Name = "btnViewRulesTenant";
            this.btnViewRulesTenant.Size = new System.Drawing.Size(75, 23);
            this.btnViewRulesTenant.TabIndex = 1;
            this.btnViewRulesTenant.Text = "View Rules";
            this.btnViewRulesTenant.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clearResultsButton
            // 
            this.clearResultsButton.BackColor = System.Drawing.Color.Lavender;
            this.clearResultsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearResultsButton.Location = new System.Drawing.Point(158, 585);
            this.clearResultsButton.Name = "clearResultsButton";
            this.clearResultsButton.Size = new System.Drawing.Size(263, 45);
            this.clearResultsButton.TabIndex = 7;
            this.clearResultsButton.Text = "Clear Results";
            this.clearResultsButton.UseVisualStyleBackColor = false;
            this.clearResultsButton.Click += new System.EventHandler(this.clearResultsButton_Click);
            // 
            // TenantBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1338, 752);
            this.Controls.Add(this.tabControl1);
            this.Name = "TenantBuildingForm";
            this.Text = "Student";
            this.tabControl1.ResumeLayout(false);
            this.calendarTabPage.ResumeLayout(false);
            this.groceriesTabPage.ResumeLayout(false);
            this.groceriesTabPage.PerformLayout();
            this.rulesTabPage.ResumeLayout(false);
            this.complaintsTabPage.ResumeLayout(false);
            this.complaintsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calendarTabPage;
        private System.Windows.Forms.ListBox calendarListBox;
        private System.Windows.Forms.TabPage rulesTabPage;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Button showTimeSpecificTaskButton;
        private System.Windows.Forms.DateTimePicker calendarDateTimePicker;
        private System.Windows.Forms.ListBox rulesListBox;
        private System.Windows.Forms.TabPage complaintsTabPage;
        private System.Windows.Forms.Button removeComplaintButton;
        private System.Windows.Forms.Button submitComplaintButton;
        private System.Windows.Forms.ListBox complaintsListBox;
        private System.Windows.Forms.Button showAllTasksButton;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button sendMailButton;

        private System.Windows.Forms.Button btnViewRulesTenant;
        private System.Windows.Forms.CheckedListBox calendarCheckedListBox;
        private System.Windows.Forms.Button taskDoneButton;
        private System.Windows.Forms.TabPage groceriesTabPage;
        private System.Windows.Forms.Label groceriesTotalCostLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.TextBox groceriesTotalCostTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.ListBox owedGroceriesListBox;
        private System.Windows.Forms.ListBox groceriesListBox;
        private System.Windows.Forms.Button payGroceriesButton;
        private System.Windows.Forms.Button showAllCompletedTasksButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button clearResultsButton;
    }
}