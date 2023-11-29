namespace login
{
    partial class PCSitStatusForm
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
            this.txtSitPower = new System.Windows.Forms.Label();
            this.txtSitMalfunction = new System.Windows.Forms.Label();
            this.txtSelectedSitNo = new System.Windows.Forms.Label();
            this.txtLoginedUser = new System.Windows.Forms.Label();
            this.txtRemainedTime = new System.Windows.Forms.Label();
            this.ForcedPowerOffBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSitPower
            // 
            this.txtSitPower.AutoSize = true;
            this.txtSitPower.Location = new System.Drawing.Point(50, 61);
            this.txtSitPower.Name = "txtSitPower";
            this.txtSitPower.Size = new System.Drawing.Size(45, 15);
            this.txtSitPower.TabIndex = 0;
            this.txtSitPower.Text = "label1";
            // 
            // txtSitMalfunction
            // 
            this.txtSitMalfunction.AutoSize = true;
            this.txtSitMalfunction.Location = new System.Drawing.Point(50, 105);
            this.txtSitMalfunction.Name = "txtSitMalfunction";
            this.txtSitMalfunction.Size = new System.Drawing.Size(45, 15);
            this.txtSitMalfunction.TabIndex = 1;
            this.txtSitMalfunction.Text = "label2";
            // 
            // txtSelectedSitNo
            // 
            this.txtSelectedSitNo.AutoSize = true;
            this.txtSelectedSitNo.Location = new System.Drawing.Point(233, 13);
            this.txtSelectedSitNo.Name = "txtSelectedSitNo";
            this.txtSelectedSitNo.Size = new System.Drawing.Size(45, 15);
            this.txtSelectedSitNo.TabIndex = 2;
            this.txtSelectedSitNo.Text = "label1";
            // 
            // txtLoginedUser
            // 
            this.txtLoginedUser.AutoSize = true;
            this.txtLoginedUser.Location = new System.Drawing.Point(50, 155);
            this.txtLoginedUser.Name = "txtLoginedUser";
            this.txtLoginedUser.Size = new System.Drawing.Size(45, 15);
            this.txtLoginedUser.TabIndex = 3;
            this.txtLoginedUser.Text = "label2";
            // 
            // txtRemainedTime
            // 
            this.txtRemainedTime.AutoSize = true;
            this.txtRemainedTime.Location = new System.Drawing.Point(50, 192);
            this.txtRemainedTime.Name = "txtRemainedTime";
            this.txtRemainedTime.Size = new System.Drawing.Size(45, 15);
            this.txtRemainedTime.TabIndex = 4;
            this.txtRemainedTime.Text = "label2";
            // 
            // ForcedPowerOffBtn
            // 
            this.ForcedPowerOffBtn.Location = new System.Drawing.Point(410, 117);
            this.ForcedPowerOffBtn.Name = "ForcedPowerOffBtn";
            this.ForcedPowerOffBtn.Size = new System.Drawing.Size(75, 23);
            this.ForcedPowerOffBtn.TabIndex = 5;
            this.ForcedPowerOffBtn.Text = "button1";
            this.ForcedPowerOffBtn.UseVisualStyleBackColor = true;
            this.ForcedPowerOffBtn.Click += new System.EventHandler(this.ForcedPowerOffBtn_Click);
            // 
            // PCSitStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 249);
            this.Controls.Add(this.ForcedPowerOffBtn);
            this.Controls.Add(this.txtRemainedTime);
            this.Controls.Add(this.txtLoginedUser);
            this.Controls.Add(this.txtSelectedSitNo);
            this.Controls.Add(this.txtSitMalfunction);
            this.Controls.Add(this.txtSitPower);
            this.Name = "PCSitStatusForm";
            this.Text = "PCSitStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSitPower;
        private System.Windows.Forms.Label txtSitMalfunction;
        private System.Windows.Forms.Label txtSelectedSitNo;
        private System.Windows.Forms.Label txtLoginedUser;
        private System.Windows.Forms.Label txtRemainedTime;
        private System.Windows.Forms.Button ForcedPowerOffBtn;
    }
}