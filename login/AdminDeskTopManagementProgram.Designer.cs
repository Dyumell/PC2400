namespace login
{
    partial class AdminDeskTopManagementProgram
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
            this.AdminDeskTopManagementProgramEmergencyExitBtn = new System.Windows.Forms.Button();
            this.TestADTMPRecievedDataBtn = new System.Windows.Forms.Button();
            this.labelADTMPUserID = new System.Windows.Forms.Label();
            this.SearchAccountBtn = new System.Windows.Forms.Button();
            this.SitManagementBtn = new System.Windows.Forms.Button();
            this.CreateStaffIDBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminDeskTopManagementProgramEmergencyExitBtn
            // 
            this.AdminDeskTopManagementProgramEmergencyExitBtn.Location = new System.Drawing.Point(587, 363);
            this.AdminDeskTopManagementProgramEmergencyExitBtn.Name = "AdminDeskTopManagementProgramEmergencyExitBtn";
            this.AdminDeskTopManagementProgramEmergencyExitBtn.Size = new System.Drawing.Size(166, 63);
            this.AdminDeskTopManagementProgramEmergencyExitBtn.TabIndex = 0;
            this.AdminDeskTopManagementProgramEmergencyExitBtn.Text = "Emergency Exit";
            this.AdminDeskTopManagementProgramEmergencyExitBtn.UseVisualStyleBackColor = true;
            this.AdminDeskTopManagementProgramEmergencyExitBtn.Click += new System.EventHandler(this.AdminDeskTopManagementProgramEmergencyExitBtn_Click);
            // 
            // TestADTMPRecievedDataBtn
            // 
            this.TestADTMPRecievedDataBtn.Location = new System.Drawing.Point(587, 254);
            this.TestADTMPRecievedDataBtn.Name = "TestADTMPRecievedDataBtn";
            this.TestADTMPRecievedDataBtn.Size = new System.Drawing.Size(188, 103);
            this.TestADTMPRecievedDataBtn.TabIndex = 1;
            this.TestADTMPRecievedDataBtn.Text = "계정 연결 테스트";
            this.TestADTMPRecievedDataBtn.UseVisualStyleBackColor = true;
            this.TestADTMPRecievedDataBtn.Click += new System.EventHandler(this.TestADTMPRecievedDataBtn_Click);
            // 
            // labelADTMPUserID
            // 
            this.labelADTMPUserID.AutoSize = true;
            this.labelADTMPUserID.Location = new System.Drawing.Point(355, 21);
            this.labelADTMPUserID.Name = "labelADTMPUserID";
            this.labelADTMPUserID.Size = new System.Drawing.Size(48, 15);
            this.labelADTMPUserID.TabIndex = 2;
            this.labelADTMPUserID.Text = "userID";
            // 
            // SearchAccountBtn
            // 
            this.SearchAccountBtn.Location = new System.Drawing.Point(51, 100);
            this.SearchAccountBtn.Name = "SearchAccountBtn";
            this.SearchAccountBtn.Size = new System.Drawing.Size(138, 106);
            this.SearchAccountBtn.TabIndex = 3;
            this.SearchAccountBtn.Text = "회원정보 검색\r\n";
            this.SearchAccountBtn.UseVisualStyleBackColor = true;
            this.SearchAccountBtn.Click += new System.EventHandler(this.SearchAccountBtn_Click);
            // 
            // SitManagementBtn
            // 
            this.SitManagementBtn.Location = new System.Drawing.Point(51, 223);
            this.SitManagementBtn.Name = "SitManagementBtn";
            this.SitManagementBtn.Size = new System.Drawing.Size(138, 99);
            this.SitManagementBtn.TabIndex = 4;
            this.SitManagementBtn.Text = "자리관리";
            this.SitManagementBtn.UseVisualStyleBackColor = true;
            this.SitManagementBtn.Click += new System.EventHandler(this.SitManagementBtn_Click);
            // 
            // CreateStaffIDBtn
            // 
            this.CreateStaffIDBtn.Location = new System.Drawing.Point(51, 348);
            this.CreateStaffIDBtn.Name = "CreateStaffIDBtn";
            this.CreateStaffIDBtn.Size = new System.Drawing.Size(124, 67);
            this.CreateStaffIDBtn.TabIndex = 5;
            this.CreateStaffIDBtn.Text = "직원 계정 생성";
            this.CreateStaffIDBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 99);
            this.button2.TabIndex = 7;
            this.button2.Text = "주문대기열";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminDeskTopManagementProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateStaffIDBtn);
            this.Controls.Add(this.SitManagementBtn);
            this.Controls.Add(this.SearchAccountBtn);
            this.Controls.Add(this.labelADTMPUserID);
            this.Controls.Add(this.TestADTMPRecievedDataBtn);
            this.Controls.Add(this.AdminDeskTopManagementProgramEmergencyExitBtn);
            this.MaximizeBox = false;
            this.Name = "AdminDeskTopManagementProgram";
            this.Text = "AdminDeskTopManagementProgram";
            this.Load += new System.EventHandler(this.AdminDeskTopManagementProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminDeskTopManagementProgramEmergencyExitBtn;
        private System.Windows.Forms.Button TestADTMPRecievedDataBtn;
        private System.Windows.Forms.Label labelADTMPUserID;
        private System.Windows.Forms.Button SearchAccountBtn;
        private System.Windows.Forms.Button SitManagementBtn;
        private System.Windows.Forms.Button CreateStaffIDBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}