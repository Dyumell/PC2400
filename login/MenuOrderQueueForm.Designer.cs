namespace test1
{
    partial class MeneuOrderListQueueForm
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
            System.Windows.Forms.ColumnHeader OrderUserID;
            this.OrderListView = new System.Windows.Forms.ListView();
            this.OrderNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderSitNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderMenu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TextMenuDescription = new System.Windows.Forms.TextBox();
            this.HiddenOrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            OrderUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // OrderUserID
            // 
            OrderUserID.Text = "아이디";
            OrderUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            OrderUserID.Width = 100;
            // 
            // OrderListView
            // 
            this.OrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderNO,
            this.OrderSitNo,
            OrderUserID,
            this.OrderMenu,
            this.OrderPrice,
            this.HiddenOrderTime});
            this.OrderListView.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderListView.FullRowSelect = true;
            this.OrderListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(46, 25);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(594, 368);
            this.OrderListView.TabIndex = 0;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.View = System.Windows.Forms.View.Details;
            this.OrderListView.SelectedIndexChanged += new System.EventHandler(this.OrderListView_SelectedIndexChanged);
            // 
            // OrderNO
            // 
            this.OrderNO.Text = "주문번호";
            this.OrderNO.Width = 100;
            // 
            // OrderSitNo
            // 
            this.OrderSitNo.Text = "좌석";
            this.OrderSitNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderSitNo.Width = 88;
            // 
            // OrderMenu
            // 
            this.OrderMenu.Text = "메뉴";
            this.OrderMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderMenu.Width = 180;
            // 
            // OrderPrice
            // 
            this.OrderPrice.Text = "가격";
            this.OrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderPrice.Width = 120;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "주문완료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "주문반려";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextMenuDescription
            // 
            this.TextMenuDescription.Location = new System.Drawing.Point(46, 416);
            this.TextMenuDescription.Multiline = true;
            this.TextMenuDescription.Name = "TextMenuDescription";
            this.TextMenuDescription.Size = new System.Drawing.Size(594, 138);
            this.TextMenuDescription.TabIndex = 5;
            // 
            // HiddenOrderTime
            // 
            this.HiddenOrderTime.Text = "숨겨진 주문 시간";
            this.HiddenOrderTime.Width = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MeneuOrderListQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 643);
            this.Controls.Add(this.TextMenuDescription);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OrderListView);
            this.Name = "MeneuOrderListQueueForm";
            this.Text = "MenuOrderQueueForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MeneuOrderListQueueForm_FormClosed);
            this.Load += new System.EventHandler(this.MeneuOrderListQueueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.ColumnHeader OrderNO;
        private System.Windows.Forms.ColumnHeader OrderSitNo;
        private System.Windows.Forms.ColumnHeader OrderMenu;
        private System.Windows.Forms.ColumnHeader OrderPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TextMenuDescription;
        private System.Windows.Forms.ColumnHeader HiddenOrderTime;
        private System.Windows.Forms.Timer timer1;
    }
}