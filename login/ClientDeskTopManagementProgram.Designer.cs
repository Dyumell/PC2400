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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ChangedUserInfo = new System.Windows.Forms.Button();
            this.MenuOrderBtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CDTMPEmergencyExitBtn
            // 
            this.CDTMPEmergencyExitBtn.Location = new System.Drawing.Point(24, 282);
            this.CDTMPEmergencyExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CDTMPEmergencyExitBtn.Name = "CDTMPEmergencyExitBtn";
            this.CDTMPEmergencyExitBtn.Size = new System.Drawing.Size(144, 59);
            this.CDTMPEmergencyExitBtn.TabIndex = 0;
            this.CDTMPEmergencyExitBtn.Text = "Emergency Exit";
            this.CDTMPEmergencyExitBtn.UseVisualStyleBackColor = true;
            this.CDTMPEmergencyExitBtn.Click += new System.EventHandler(this.CDTMPEmergencyExitBtn_Click);
            // 
            // labelCDTMPUserID
            // 
            this.labelCDTMPUserID.AutoSize = true;
            this.labelCDTMPUserID.Location = new System.Drawing.Point(176, 18);
            this.labelCDTMPUserID.Name = "labelCDTMPUserID";
            this.labelCDTMPUserID.Size = new System.Drawing.Size(41, 12);
            this.labelCDTMPUserID.TabIndex = 1;
            this.labelCDTMPUserID.Text = "userID";
            // 
            // labelCDTMPSitNo
            // 
            this.labelCDTMPSitNo.AutoSize = true;
            this.labelCDTMPSitNo.Location = new System.Drawing.Point(263, 74);
            this.labelCDTMPSitNo.Name = "labelCDTMPSitNo";
            this.labelCDTMPSitNo.Size = new System.Drawing.Size(53, 12);
            this.labelCDTMPSitNo.TabIndex = 2;
            this.labelCDTMPSitNo.Text = "좌석번호";
            // 
            // labelCDTMPRemainedTime
            // 
            this.labelCDTMPRemainedTime.AutoSize = true;
            this.labelCDTMPRemainedTime.Location = new System.Drawing.Point(60, 74);
            this.labelCDTMPRemainedTime.Name = "labelCDTMPRemainedTime";
            this.labelCDTMPRemainedTime.Size = new System.Drawing.Size(53, 12);
            this.labelCDTMPRemainedTime.TabIndex = 3;
            this.labelCDTMPRemainedTime.Text = "남은시간";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "남은시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "좌석번호";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ChangedUserInfo
            // 
            this.ChangedUserInfo.Location = new System.Drawing.Point(234, 282);
            this.ChangedUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangedUserInfo.Name = "ChangedUserInfo";
            this.ChangedUserInfo.Size = new System.Drawing.Size(139, 59);
            this.ChangedUserInfo.TabIndex = 10;
            this.ChangedUserInfo.Text = "회원정보 수정";
            this.ChangedUserInfo.UseVisualStyleBackColor = true;
            // 
            // MenuOrderBtn
            // 
            this.MenuOrderBtn.Location = new System.Drawing.Point(26, 190);
            this.MenuOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuOrderBtn.Name = "MenuOrderBtn";
            this.MenuOrderBtn.Size = new System.Drawing.Size(347, 57);
            this.MenuOrderBtn.TabIndex = 11;
            this.MenuOrderBtn.Text = "먹거리 주문";
            this.MenuOrderBtn.UseVisualStyleBackColor = true;
            this.MenuOrderBtn.Click += new System.EventHandler(this.MenuOrderBtn_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ClientDeskTopManagementProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 360);
            this.Controls.Add(this.MenuOrderBtn);
            this.Controls.Add(this.ChangedUserInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCDTMPRemainedTime);
            this.Controls.Add(this.labelCDTMPSitNo);
            this.Controls.Add(this.labelCDTMPUserID);
            this.Controls.Add(this.CDTMPEmergencyExitBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ChangedUserInfo;
        private System.Windows.Forms.Button MenuOrderBtn;
        private System.Windows.Forms.Timer timer2;
    }
}