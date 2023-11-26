namespace Kiosk
{
    partial class SearchID
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
            this.SearchUserID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchUserID
            // 
            this.SearchUserID.Location = new System.Drawing.Point(456, 30);
            this.SearchUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchUserID.Name = "SearchUserID";
            this.SearchUserID.Size = new System.Drawing.Size(62, 27);
            this.SearchUserID.TabIndex = 12;
            this.SearchUserID.Text = "검색";
            this.SearchUserID.UseVisualStyleBackColor = true;
            this.SearchUserID.Click += new System.EventHandler(this.SearchUserID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = " 아이디";
            // 
            // txtSearchUserID
            // 
            this.txtSearchUserID.Font = new System.Drawing.Font("굴림", 16F);
            this.txtSearchUserID.Location = new System.Drawing.Point(114, 30);
            this.txtSearchUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchUserID.Name = "txtSearchUserID";
            this.txtSearchUserID.Size = new System.Drawing.Size(312, 32);
            this.txtSearchUserID.TabIndex = 10;
            // 
            // SearchID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 106);
            this.Controls.Add(this.SearchUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchUserID);
            this.Name = "SearchID";
            this.Text = "SearchID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUserID;
    }
}