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
            this.CDTMPEmergencyExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CDTMPEmergencyExitBtn
            // 
            this.CDTMPEmergencyExitBtn.Location = new System.Drawing.Point(561, 28);
            this.CDTMPEmergencyExitBtn.Name = "CDTMPEmergencyExitBtn";
            this.CDTMPEmergencyExitBtn.Size = new System.Drawing.Size(166, 57);
            this.CDTMPEmergencyExitBtn.TabIndex = 0;
            this.CDTMPEmergencyExitBtn.Text = "Emergency Exit";
            this.CDTMPEmergencyExitBtn.UseVisualStyleBackColor = true;
            this.CDTMPEmergencyExitBtn.Click += new System.EventHandler(this.CDTMPEmergencyExitBtn_Click);
            // 
            // ClientDeskTopManagementProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.CDTMPEmergencyExitBtn);
            this.Name = "ClientDeskTopManagementProgram";
            this.Text = "ClientManagementProgram";
            this.MaximizeBox = false;
            this.ResumeLayout(false);

}

        #endregion

        private System.Windows.Forms.Button CDTMPEmergencyExitBtn;
    }
}