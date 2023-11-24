namespace login
{
    partial class ClientDeskTopManagementProgram
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
            this.CDTMPEmergencyExitBtn = new System.Windows.Forms.Button();
            this.labelCDTMPUserID = new System.Windows.Forms.Label();
            this.labelCDTMPSitNo = new System.Windows.Forms.Label();
            this.labelCDTMPRemainedTime = new System.Windows.Forms.Label();
            this.TestReceiveSelectedRowBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CDTMPEmergencyExitBtn
            // 
            this.CDTMPEmergencyExitBtn.Location = new System.Drawing.Point(25, 360);
            this.CDTMPEmergencyExitBtn.Name = "CDTMPEmergencyExitBtn";
            this.CDTMPEmergencyExitBtn.Size = new System.Drawing.Size(166, 57);
            this.CDTMPEmergencyExitBtn.TabIndex = 0;
            this.CDTMPEmergencyExitBtn.Text = "Emergency Exit";
            this.CDTMPEmergencyExitBtn.UseVisualStyleBackColor = true;
            this.CDTMPEmergencyExitBtn.Click += new System.EventHandler(this.CDTMPEmergencyExitBtn_Click);
            // 
            // labelCDTMPUserID
            // 
            this.labelCDTMPUserID.AutoSize = true;
            this.labelCDTMPUserID.Location = new System.Drawing.Point(201, 23);
            this.labelCDTMPUserID.Name = "labelCDTMPUserID";
            this.labelCDTMPUserID.Size = new System.Drawing.Size(48, 15);
            this.labelCDTMPUserID.TabIndex = 1;
            this.labelCDTMPUserID.Text = "userID";
            // 
            // labelCDTMPSitNo
            // 
            this.labelCDTMPSitNo.AutoSize = true;
            this.labelCDTMPSitNo.Location = new System.Drawing.Point(301, 93);
            this.labelCDTMPSitNo.Name = "labelCDTMPSitNo";
            this.labelCDTMPSitNo.Size = new System.Drawing.Size(67, 15);
            this.labelCDTMPSitNo.TabIndex = 2;
            this.labelCDTMPSitNo.Text = "좌석번호";
            // 
            // labelCDTMPRemainedTime
            // 
            this.labelCDTMPRemainedTime.AutoSize = true;
            this.labelCDTMPRemainedTime.Location = new System.Drawing.Point(68, 93);
            this.labelCDTMPRemainedTime.Name = "labelCDTMPRemainedTime";
            this.labelCDTMPRemainedTime.Size = new System.Drawing.Size(67, 15);
            this.labelCDTMPRemainedTime.TabIndex = 3;
            this.labelCDTMPRemainedTime.Text = "남은시간";
            // 
            // TestReceiveSelectedRowBtn
            // 
            this.TestReceiveSelectedRowBtn.Location = new System.Drawing.Point(44, 259);
            this.TestReceiveSelectedRowBtn.Name = "TestReceiveSelectedRowBtn";
            this.TestReceiveSelectedRowBtn.Size = new System.Drawing.Size(132, 83);
            this.TestReceiveSelectedRowBtn.TabIndex = 4;
            this.TestReceiveSelectedRowBtn.Text = "로그인한아이디넘겨받기";
            this.TestReceiveSelectedRowBtn.UseVisualStyleBackColor = true;
            this.TestReceiveSelectedRowBtn.Click += new System.EventHandler(this.TestReceiveSelectedRowBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "남은시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "좌석번호";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "시간확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "시간차감";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ClientDeskTopManagementProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestReceiveSelectedRowBtn);
            this.Controls.Add(this.labelCDTMPRemainedTime);
            this.Controls.Add(this.labelCDTMPSitNo);
            this.Controls.Add(this.labelCDTMPUserID);
            this.Controls.Add(this.CDTMPEmergencyExitBtn);
            this.MaximizeBox = false;
            this.Name = "ClientDeskTopManagementProgram";
            this.Text = "ClientManagementProgram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientDeskTopManagementProgram_FormClosed);
            this.Load += new System.EventHandler(this.ClientDeskTopManagementProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

}

        #endregion

        private System.Windows.Forms.Button CDTMPEmergencyExitBtn;
        private System.Windows.Forms.Label labelCDTMPUserID;
        private System.Windows.Forms.Label labelCDTMPSitNo;
        private System.Windows.Forms.Label labelCDTMPRemainedTime;
        private System.Windows.Forms.Button TestReceiveSelectedRowBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}