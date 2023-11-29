namespace Kiosk
{
    partial class Kiosk
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
            this.label5 = new System.Windows.Forms.Label();
            this.totalmoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idnowgenzai = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totaltime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idnow = new System.Windows.Forms.Label();
            this.roundedPanel2 = new login.RoundedPanel();
            this.roundedPanel1 = new login.RoundedPanel();
            this.roundButton8 = new login.RoundButton();
            this.roundButton7 = new login.RoundButton();
            this.roundButton6 = new login.RoundButton();
            this.roundButton5 = new login.RoundButton();
            this.roundButton4 = new login.RoundButton();
            this.roundButton3 = new login.RoundButton();
            this.roundButton2 = new login.RoundButton();
            this.roundButton1 = new login.RoundButton();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(677, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "이용가능 좌석 : n석";
            // 
            // totalmoney
            // 
            this.totalmoney.AutoSize = true;
            this.totalmoney.Font = new System.Drawing.Font("굴림", 13F);
            this.totalmoney.Location = new System.Drawing.Point(769, 113);
            this.totalmoney.Name = "totalmoney";
            this.totalmoney.Size = new System.Drawing.Size(36, 18);
            this.totalmoney.TabIndex = 21;
            this.totalmoney.Text = "0원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(677, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "누적금액 : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 69);
            this.button1.TabIndex = 19;
            this.button1.Text = "결제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F);
            this.label6.Location = new System.Drawing.Point(677, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "사용중인 좌석 : n석";
            // 
            // idnowgenzai
            // 
            this.idnowgenzai.AutoSize = true;
            this.idnowgenzai.Font = new System.Drawing.Font("굴림", 12F);
            this.idnowgenzai.Location = new System.Drawing.Point(29, 173);
            this.idnowgenzai.Name = "idnowgenzai";
            this.idnowgenzai.Size = new System.Drawing.Size(102, 16);
            this.idnowgenzai.TabIndex = 26;
            this.idnowgenzai.Text = "현재 아이디 :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 15F);
            this.button2.Location = new System.Drawing.Point(274, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 59);
            this.button2.TabIndex = 25;
            this.button2.Text = "아이디 검색";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 67);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kiosk 2400";
            // 
            // totaltime
            // 
            this.totaltime.AutoSize = true;
            this.totaltime.Font = new System.Drawing.Font("굴림", 13F);
            this.totaltime.Location = new System.Drawing.Point(769, 143);
            this.totaltime.Name = "totaltime";
            this.totaltime.Size = new System.Drawing.Size(54, 18);
            this.totaltime.TabIndex = 30;
            this.totaltime.Text = "0시간";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F);
            this.label9.Location = new System.Drawing.Point(677, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "누적시간 : ";
            // 
            // idnow
            // 
            this.idnow.AutoSize = true;
            this.idnow.Location = new System.Drawing.Point(137, 173);
            this.idnow.Name = "idnow";
            this.idnow.Size = new System.Drawing.Size(41, 12);
            this.idnow.TabIndex = 31;
            this.idnow.Text = "미선택";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Location = new System.Drawing.Point(430, 250);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(523, 385);
            this.roundedPanel2.TabIndex = 28;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.roundButton8);
            this.roundedPanel1.Controls.Add(this.roundButton7);
            this.roundedPanel1.Controls.Add(this.roundButton6);
            this.roundedPanel1.Controls.Add(this.roundButton5);
            this.roundedPanel1.Controls.Add(this.roundButton4);
            this.roundedPanel1.Controls.Add(this.roundButton3);
            this.roundedPanel1.Controls.Add(this.roundButton2);
            this.roundedPanel1.Controls.Add(this.roundButton1);
            this.roundedPanel1.Location = new System.Drawing.Point(61, 252);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(310, 383);
            this.roundedPanel1.TabIndex = 27;
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton8.FlatAppearance.BorderSize = 0;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton8.ForeColor = System.Drawing.Color.Black;
            this.roundButton8.Location = new System.Drawing.Point(153, 288);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(126, 71);
            this.roundButton8.TabIndex = 7;
            this.roundButton8.Text = "60시간\\n50000원";
            this.roundButton8.UseVisualStyleBackColor = false;
            this.roundButton8.Click += new System.EventHandler(this.roundButton8_Click);
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton7.ForeColor = System.Drawing.Color.Black;
            this.roundButton7.Location = new System.Drawing.Point(21, 288);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(126, 71);
            this.roundButton7.TabIndex = 6;
            this.roundButton7.Text = "38시간\\n30000원";
            this.roundButton7.UseVisualStyleBackColor = false;
            this.roundButton7.Click += new System.EventHandler(this.roundButton7_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton6.ForeColor = System.Drawing.Color.Black;
            this.roundButton6.Location = new System.Drawing.Point(153, 201);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(126, 71);
            this.roundButton6.TabIndex = 5;
            this.roundButton6.Text = "25시간\\n20000원";
            this.roundButton6.UseVisualStyleBackColor = false;
            this.roundButton6.Click += new System.EventHandler(this.roundButton6_Click);
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton5.ForeColor = System.Drawing.Color.Black;
            this.roundButton5.Location = new System.Drawing.Point(21, 201);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(126, 71);
            this.roundButton5.TabIndex = 4;
            this.roundButton5.Text = "12시간\\n10000원";
            this.roundButton5.UseVisualStyleBackColor = false;
            this.roundButton5.Click += new System.EventHandler(this.roundButton5_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton4.ForeColor = System.Drawing.Color.Black;
            this.roundButton4.Location = new System.Drawing.Point(153, 111);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(126, 71);
            this.roundButton4.TabIndex = 3;
            this.roundButton4.Text = "5시간\\n5000원";
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton3.ForeColor = System.Drawing.Color.Black;
            this.roundButton3.Location = new System.Drawing.Point(21, 111);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(126, 71);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "3시간\\n3000원";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(158, 20);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(126, 71);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "2시간\\n2000원";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Arial", 12F);
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(21, 20);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(126, 71);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "1시간\\n1000원";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Kiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 671);
            this.Controls.Add(this.idnow);
            this.Controls.Add(this.totaltime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalmoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idnowgenzai);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Name = "Kiosk";
            this.Text = "Kiosk2400";
            this.Load += new System.EventHandler(this.Kiosk_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idnowgenzai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private login.RoundButton roundButton8;
        private login.RoundButton roundButton7;
        private login.RoundButton roundButton6;
        private login.RoundButton roundButton5;
        private login.RoundButton roundButton4;
        private login.RoundButton roundButton3;
        private login.RoundButton roundButton2;
        private login.RoundButton roundButton1;
        private login.RoundedPanel roundedPanel2;
        private login.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label totaltime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label idnow;
    }
}

