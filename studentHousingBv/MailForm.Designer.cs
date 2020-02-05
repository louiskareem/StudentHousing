namespace studentHousingBv
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.emailBodyTextBox = new System.Windows.Forms.TextBox();
            this.sendDailyReportButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.cancelEmailButton = new System.Windows.Forms.Button();
            this.receiverEmailTextBox = new System.Windows.Forms.TextBox();
            this.senderEmailTextBox = new System.Windows.Forms.TextBox();
            this.senderPassword = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bodyLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // emailBodyTextBox
            // 
            this.emailBodyTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBodyTextBox.Location = new System.Drawing.Point(186, 12);
            this.emailBodyTextBox.Multiline = true;
            this.emailBodyTextBox.Name = "emailBodyTextBox";
            this.emailBodyTextBox.Size = new System.Drawing.Size(490, 248);
            this.emailBodyTextBox.TabIndex = 0;
            // 
            // sendDailyReportButton
            // 
            this.sendDailyReportButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.sendDailyReportButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendDailyReportButton.Location = new System.Drawing.Point(186, 388);
            this.sendDailyReportButton.Name = "sendDailyReportButton";
            this.sendDailyReportButton.Size = new System.Drawing.Size(209, 50);
            this.sendDailyReportButton.TabIndex = 1;
            this.sendDailyReportButton.Text = "Send Daily Report";
            this.sendDailyReportButton.UseVisualStyleBackColor = false;
            this.sendDailyReportButton.Click += new System.EventHandler(this.sendDailyReportButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sendEmailButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.Location = new System.Drawing.Point(401, 388);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(147, 50);
            this.sendEmailButton.TabIndex = 2;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // cancelEmailButton
            // 
            this.cancelEmailButton.BackColor = System.Drawing.Color.LightCoral;
            this.cancelEmailButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEmailButton.Location = new System.Drawing.Point(554, 388);
            this.cancelEmailButton.Name = "cancelEmailButton";
            this.cancelEmailButton.Size = new System.Drawing.Size(122, 50);
            this.cancelEmailButton.TabIndex = 3;
            this.cancelEmailButton.Text = "Cancel";
            this.cancelEmailButton.UseVisualStyleBackColor = false;
            this.cancelEmailButton.Click += new System.EventHandler(this.cancelEmailButton_Click);
            // 
            // receiverEmailTextBox
            // 
            this.receiverEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiverEmailTextBox.Location = new System.Drawing.Point(186, 266);
            this.receiverEmailTextBox.Name = "receiverEmailTextBox";
            this.receiverEmailTextBox.Size = new System.Drawing.Size(490, 30);
            this.receiverEmailTextBox.TabIndex = 4;
            // 
            // senderEmailTextBox
            // 
            this.senderEmailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderEmailTextBox.Location = new System.Drawing.Point(186, 302);
            this.senderEmailTextBox.Name = "senderEmailTextBox";
            this.senderEmailTextBox.Size = new System.Drawing.Size(490, 30);
            this.senderEmailTextBox.TabIndex = 5;
            // 
            // senderPassword
            // 
            this.senderPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderPassword.Location = new System.Drawing.Point(186, 338);
            this.senderPassword.Name = "senderPassword";
            this.senderPassword.Size = new System.Drawing.Size(490, 30);
            this.senderPassword.TabIndex = 6;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(131, 269);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(35, 22);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "To:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(105, 305);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(61, 22);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(66, 341);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 22);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLabel.Location = new System.Drawing.Point(104, 17);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(62, 22);
            this.bodyLabel.TabIndex = 10;
            this.bodyLabel.Text = "Body:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.senderPassword);
            this.Controls.Add(this.senderEmailTextBox);
            this.Controls.Add(this.receiverEmailTextBox);
            this.Controls.Add(this.cancelEmailButton);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.sendDailyReportButton);
            this.Controls.Add(this.emailBodyTextBox);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailBodyTextBox;
        private System.Windows.Forms.Button sendDailyReportButton;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button cancelEmailButton;
        private System.Windows.Forms.TextBox receiverEmailTextBox;
        private System.Windows.Forms.TextBox senderEmailTextBox;
        private System.Windows.Forms.TextBox senderPassword;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Timer timer2;
    }
}