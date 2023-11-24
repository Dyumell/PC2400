namespace login
{
    partial class SitManagementForm
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
            this.roundedPanel1 = new login.RoundedPanel();
            this.roundedPanel2 = new login.RoundedPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Location = new System.Drawing.Point(23, -35);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 60;
            this.roundedPanel1.Size = new System.Drawing.Size(1171, 561);
            this.roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.roundedPanel2.Controls.Add(this.button3);
            this.roundedPanel2.Controls.Add(this.button2);
            this.roundedPanel2.Controls.Add(this.button1);
            this.roundedPanel2.Location = new System.Drawing.Point(29, 57);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 60;
            this.roundedPanel2.Size = new System.Drawing.Size(1113, 463);
            this.roundedPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SitManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 546);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "SitManagementForm";
            this.Text = "SitManagementForm";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}