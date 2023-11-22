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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userRegisterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectTest = new System.Windows.Forms.Button();
            this.emergencyExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginID
            // 
            this.txtLoginID.Font = new System.Drawing.Font("굴림", 24F);
            this.txtLoginID.Location = new System.Drawing.Point(301, 22);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(266, 53);
            this.txtLoginID.TabIndex = 0;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Font = new System.Drawing.Font("굴림", 24F);
            this.txtLoginPwd.Location = new System.Drawing.Point(301, 95);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(266, 53);
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.PasswordChar = '*'; // 이걸 사용하면 텍스트박스에서 출력되는 문자는 전부 * 하지만 저장된 데이터는 입력된 데이터와 동일.
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.LoginBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(608, 7);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(110, 50);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "로그인";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 224);
            this.panel1.TabIndex = 5;
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
            this.panel2.Location = new System.Drawing.Point(103, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 179);
            this.panel2.TabIndex = 8;
            // 
            // userRegisterBtn
            // 
            this.userRegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.userRegisterBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.userRegisterBtn.Location = new System.Drawing.Point(608, 54);
            this.userRegisterBtn.Name = "userRegisterBtn";
            this.userRegisterBtn.Size = new System.Drawing.Size(110, 58);
            this.userRegisterBtn.TabIndex = 8;
            this.userRegisterBtn.Text = "회원가입";
            this.userRegisterBtn.UseVisualStyleBackColor = false;
            this.userRegisterBtn.Click += new System.EventHandler(this.userRegisterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(82, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "비밀번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원 아이디 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 84);
            this.label3.TabIndex = 8;
            this.label3.Text = "PC2400";
            // 
            // connectTest
            // 
            this.connectTest.Location = new System.Drawing.Point(805, 22);
            this.connectTest.Name = "connectTest";
            this.connectTest.Size = new System.Drawing.Size(128, 45);
            this.connectTest.TabIndex = 9;
            this.connectTest.Text = "Connection Test";
            this.connectTest.UseVisualStyleBackColor = true;
            this.connectTest.Click += new System.EventHandler(this.connectTest_Click);
            // 
            // emergencyExit
            // 
            this.emergencyExit.Location = new System.Drawing.Point(805, 73);
            this.emergencyExit.Name = "emergencyExit";
            this.emergencyExit.Size = new System.Drawing.Size(128, 45);
            this.emergencyExit.TabIndex = 10;
            this.emergencyExit.Text = "Emergency Exit";
            this.emergencyExit.UseVisualStyleBackColor = true;
            this.emergencyExit.Click += new System.EventHandler(this.emergencyExit_Click);
            // 
            // LockedDeskTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.emergencyExit);
            this.Controls.Add(this.connectTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "LockedDeskTop";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockedDeskTop_FormClosed);
            this.Load += new System.EventHandler(this.LockedDeskTop_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectTest;
        private System.Windows.Forms.Button userRegisterBtn;
        private System.Windows.Forms.Button emergencyExit;
    }
}

