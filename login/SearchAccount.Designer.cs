namespace login
{
    partial class SearchAccount
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
            this.txtSearchUserID = new System.Windows.Forms.TextBox();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.txtSearchUserMail = new System.Windows.Forms.TextBox();
            this.txtSearchUserPhoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchUserID = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewSearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchUserNameBtn = new System.Windows.Forms.Button();
            this.SearchUserPhoneBtn = new System.Windows.Forms.Button();
            this.SearchUserMailBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchUserID
            // 
            this.txtSearchUserID.Font = new System.Drawing.Font("굴림", 16F);
            this.txtSearchUserID.Location = new System.Drawing.Point(293, 11);
            this.txtSearchUserID.Name = "txtSearchUserID";
            this.txtSearchUserID.Size = new System.Drawing.Size(206, 38);
            this.txtSearchUserID.TabIndex = 0;
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Font = new System.Drawing.Font("굴림", 16F);
            this.txtSearchUserName.Location = new System.Drawing.Point(293, 77);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(206, 38);
            this.txtSearchUserName.TabIndex = 1;
            // 
            // txtSearchUserMail
            // 
            this.txtSearchUserMail.Font = new System.Drawing.Font("굴림", 16F);
            this.txtSearchUserMail.Location = new System.Drawing.Point(293, 201);
            this.txtSearchUserMail.Name = "txtSearchUserMail";
            this.txtSearchUserMail.Size = new System.Drawing.Size(206, 38);
            this.txtSearchUserMail.TabIndex = 3;
            // 
            // txtSearchUserPhoneNum
            // 
            this.txtSearchUserPhoneNum.Font = new System.Drawing.Font("굴림", 16F);
            this.txtSearchUserPhoneNum.Location = new System.Drawing.Point(293, 140);
            this.txtSearchUserPhoneNum.Name = "txtSearchUserPhoneNum";
            this.txtSearchUserPhoneNum.Size = new System.Drawing.Size(206, 38);
            this.txtSearchUserPhoneNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "사용자계정 아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "사용자 성함";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "이메일";
            // 
            // SearchUserID
            // 
            this.SearchUserID.Location = new System.Drawing.Point(505, 15);
            this.SearchUserID.Name = "SearchUserID";
            this.SearchUserID.Size = new System.Drawing.Size(71, 34);
            this.SearchUserID.TabIndex = 9;
            this.SearchUserID.Text = "검색";
            this.SearchUserID.UseVisualStyleBackColor = true;
            this.SearchUserID.Click += new System.EventHandler(this.SearchUserID_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 56);
            this.button2.TabIndex = 10;
            this.button2.Text = "사용내역 조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewSearchResult
            // 
            this.listViewSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSearchResult.FullRowSelect = true;
            this.listViewSearchResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSearchResult.HideSelection = false;
            this.listViewSearchResult.Location = new System.Drawing.Point(31, 279);
            this.listViewSearchResult.Name = "listViewSearchResult";
            this.listViewSearchResult.Size = new System.Drawing.Size(533, 202);
            this.listViewSearchResult.TabIndex = 11;
            this.listViewSearchResult.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResult.View = System.Windows.Forms.View.Details;
            this.listViewSearchResult.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "아이디";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "전화번호";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "이메일";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "비밀번호";
            this.columnHeader5.Width = 268;
            // 
            // SearchUserNameBtn
            // 
            this.SearchUserNameBtn.Location = new System.Drawing.Point(505, 80);
            this.SearchUserNameBtn.Name = "SearchUserNameBtn";
            this.SearchUserNameBtn.Size = new System.Drawing.Size(71, 34);
            this.SearchUserNameBtn.TabIndex = 12;
            this.SearchUserNameBtn.Text = "검색";
            this.SearchUserNameBtn.UseVisualStyleBackColor = true;
            this.SearchUserNameBtn.Click += new System.EventHandler(this.SearchUserNameBtn_Click);
            // 
            // SearchUserPhoneBtn
            // 
            this.SearchUserPhoneBtn.Location = new System.Drawing.Point(505, 144);
            this.SearchUserPhoneBtn.Name = "SearchUserPhoneBtn";
            this.SearchUserPhoneBtn.Size = new System.Drawing.Size(71, 34);
            this.SearchUserPhoneBtn.TabIndex = 13;
            this.SearchUserPhoneBtn.Text = "검색";
            this.SearchUserPhoneBtn.UseVisualStyleBackColor = true;
            this.SearchUserPhoneBtn.Click += new System.EventHandler(this.SearchUserPhoneBtn_Click);
            // 
            // SearchUserMailBtn
            // 
            this.SearchUserMailBtn.Location = new System.Drawing.Point(505, 204);
            this.SearchUserMailBtn.Name = "SearchUserMailBtn";
            this.SearchUserMailBtn.Size = new System.Drawing.Size(71, 34);
            this.SearchUserMailBtn.TabIndex = 14;
            this.SearchUserMailBtn.Text = "검색";
            this.SearchUserMailBtn.UseVisualStyleBackColor = true;
            this.SearchUserMailBtn.Click += new System.EventHandler(this.SearchUserMailBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 56);
            this.button4.TabIndex = 15;
            this.button4.Text = "계정삭제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(145, 496);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 56);
            this.button5.TabIndex = 16;
            this.button5.Text = "비밀번호 변경";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SearchAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 574);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SearchUserMailBtn);
            this.Controls.Add(this.SearchUserPhoneBtn);
            this.Controls.Add(this.SearchUserNameBtn);
            this.Controls.Add(this.listViewSearchResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchUserMail);
            this.Controls.Add(this.txtSearchUserPhoneNum);
            this.Controls.Add(this.txtSearchUserName);
            this.Controls.Add(this.txtSearchUserID);
            this.Name = "SearchAccount";
            this.Text = "SearchAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchUserID;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.TextBox txtSearchUserMail;
        private System.Windows.Forms.TextBox txtSearchUserPhoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchUserID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button SearchUserNameBtn;
        private System.Windows.Forms.Button SearchUserPhoneBtn;
        private System.Windows.Forms.Button SearchUserMailBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}