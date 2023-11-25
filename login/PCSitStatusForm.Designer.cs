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
            // PCSitStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 157);
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
    }
}