namespace login
{
    partial class LockedDeskTop
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userRegisterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectTest = new System.Windows.Forms.Button();
            this.emergencyExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginID
            // 
            this.txtLoginID.Font = new System.Drawing.Font("굴림", 24F);
            this.txtLoginID.Location = new System.Drawing.Point(263, 19);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(360, 44);
            this.txtLoginID.TabIndex = 0;
            this.txtLoginID.Text = "test01";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Font = new System.Drawing.Font("굴림", 24F);
            this.txtLoginPwd.Location = new System.Drawing.Point(263, 81);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(360, 44);
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.Text = "test@01";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.LoginBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(729, 5);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(118, 66);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "로그인";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.userRegisterBtn);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLoginPwd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLoginID);
            this.panel2.Location = new System.Drawing.Point(552, 831);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 167);
            this.panel2.TabIndex = 8;
            // 
            // userRegisterBtn
            // 
            this.userRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.userRegisterBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.userRegisterBtn.Location = new System.Drawing.Point(729, 71);
            this.userRegisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userRegisterBtn.Name = "userRegisterBtn";
            this.userRegisterBtn.Size = new System.Drawing.Size(118, 67);
            this.userRegisterBtn.TabIndex = 8;
            this.userRegisterBtn.Text = "회원가입";
            this.userRegisterBtn.UseVisualStyleBackColor = false;
            this.userRegisterBtn.Click += new System.EventHandler(this.userRegisterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "비밀번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원 아이디 :";
            // 
            // connectTest
            // 
            this.connectTest.Location = new System.Drawing.Point(704, 18);
            this.connectTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectTest.Name = "connectTest";
            this.connectTest.Size = new System.Drawing.Size(112, 36);
            this.connectTest.TabIndex = 9;
            this.connectTest.Text = "Connection Test";
            this.connectTest.UseVisualStyleBackColor = true;
            this.connectTest.Click += new System.EventHandler(this.connectTest_Click);
            // 
            // emergencyExit
            // 
            this.emergencyExit.Location = new System.Drawing.Point(704, 58);
            this.emergencyExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emergencyExit.Name = "emergencyExit";
            this.emergencyExit.Size = new System.Drawing.Size(112, 36);
            this.emergencyExit.TabIndex = 10;
            this.emergencyExit.Text = "Emergency Exit";
            this.emergencyExit.UseVisualStyleBackColor = true;
            this.emergencyExit.Click += new System.EventHandler(this.emergencyExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "관리자접속";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "고객접속";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.잠금화면;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LockedDeskTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emergencyExit);
            this.Controls.Add(this.connectTest);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LockedDeskTop";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockedDeskTop_FormClosed);
            this.Load += new System.EventHandler(this.LockedDeskTop_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connectTest;
        private System.Windows.Forms.Button userRegisterBtn;
        private System.Windows.Forms.Button emergencyExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

