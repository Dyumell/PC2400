using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Oracle.DataAccess.Client;


namespace login
{ 

    public partial class ClientDeskTopManagementProgram : Form // 고려사항 : 잔여시간 30 , 10 , 5 , 1 분때에 메세지 박스 출력
    {
        public void TestShowRemainedTime()
        {
            string command = "SELECT user_id,remained_time FROM user_account_login";
            DBManager DBMClient = new DBManager(command);
            DBMClient.DS.Clear();
            DBMClient.DBAdapter.Fill(DBMClient.DS, "user_account_login");
            DBMClient.UserTable = DBMClient.DS.Tables["user_account_login"];
            DBMClient.ResultRows = DBMClient.UserTable.Select("user_id = '" + loginedRow[0]["user_id"] + "'");

            MessageBox.Show(DBMClient.ResultRows[0]["remained_time"].ToString());
            
        }
        public string CheckRemainedTime()
        {
            string command = "SELECT user_id,remained_time FROM user_account_login";
            DBManager DBMClient = new DBManager(command);
            DBMClient.DS.Clear();
            DBMClient.DBAdapter.Fill(DBMClient.DS, "user_account_login");
            DBMClient.UserTable = DBMClient.DS.Tables["user_account_login"];
            DBMClient.ResultRows = DBMClient.UserTable.Select("user_id = '" + loginedRow[0]["user_id"] + "'");
            remainedTime = Convert.ToInt32(DBMClient.ResultRows[0]["remained_time"]);
            return ConvertIntToTime(remainedTime);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call the method to update remained_time
            UpdateRemainedTime();
            labelCDTMPRemainedTime.Text = ConvertIntToTime(remainedTime);
        }

        public void UpdateRemainedTime()
        {
            try
            {
                string command = "SELECT user_id,remained_time FROM user_account_login";
                DBManager DBMClient = new DBManager(command);
                DBMClient.DS.Clear();
                DBMClient.DBAdapter.Fill(DBMClient.DS, "user_account_login");

                DBMClient.UserTable = DBMClient.DS.Tables["user_account_login"];
                DBMClient.ResultRows = DBMClient.UserTable.Select("user_id = '" + loginedRow[0]["user_id"] + "'");

                remainedTime = Convert.ToInt32(DBMClient.ResultRows[0]["remained_time"]);
                remainedTime--;

                DBMClient.ResultRows[0]["remained_time"] = remainedTime;
                DBMClient.DBAdapter.Update(DBMClient.DS, "user_account_login");

                DBMClient.TransactionOpen();

                try
                {
                    DBMClient.DBAdapter.SelectCommand.Transaction = DBMClient.Transaction;
                    DBMClient.DBAdapter.Update(DBMClient.DS, "user_account_login");
                    DBMClient.Transaction.Commit();
                }
                catch (DataException DE)
                {
                    DBMClient.Transaction.Rollback();
                    throw DE;
                }

            }
            catch (DataException DE){
                MessageBox.Show(DE.Message);
            }
                
            
        }


        public ClientDeskTopManagementProgram(DataRow[] resultRows) // 로그인된 계정정보를 받기위한 생성자
        {

            
            InitializeComponent();
           
            DisableCloseButton(this.Handle);
            this.loginedRow = resultRows;
            
        }

        public ClientDeskTopManagementProgram(string accessedSitID)
        {
            

            InitializeComponent();
            DisableCloseButton(this.Handle);
            this.accessedSitID = accessedSitID;
        }

        public ClientDeskTopManagementProgram(DataRow[] resultRows ,string accessedSitID)
        {

            InitializeComponent();
            DisableCloseButton(this.Handle);
            this.loginedRow = resultRows;
            this.accessedSitID = accessedSitID;
        }
         // 위 생성자중 몇개는 추후에 삭제해야함


        #region WindowsAPI 
        //고객데스크탑관리프로그램은 종료되면 안된다.
        //이를위해 닫기버튼을 비활성화한다.
        [DllImport("user32.dll")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        public static extern int EnableMenuItem(IntPtr hWnd, uint uIDEnableItem, uint Enable);

        private const int SC_CLOSE = 0xF060;
        private const int MF_GRAYED = 0x0001;
        private const int MF_BYCOMMAND = 0x0000;
        #endregion

        int remainedTime;
        string accessedSitID;
        private DataRow[] loginedRow;
        DataSet DS; // 복사된 데이터를 저장하는 변수
        OracleCommandBuilder myCommandBuilder; // 명령문을 자동으로 짜주는 도움이변수
        OracleDataAdapter DBAdapter; // 그거
        DataTable userTable; //추가될 Row(열)을 담아놓는 변수

        string connectionString = "User Id=dyumell; Password = 1755; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
        string commandString = "SELECT * FROM user_account_login ";
        private void DisableCloseButton(IntPtr handle)
        {
            // 시스템 메뉴 핸들 가져오기
            IntPtr hMenu = GetSystemMenu(handle, false);

            // 닫기 버튼 비활성화
            EnableMenuItem(hMenu, SC_CLOSE, MF_GRAYED);
        }

        private void CDTMPEmergencyExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestReceiveSelectedRowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그인된 계정은 " + loginedRow[0]["user_id"] + " 입니다.");
        }

        private void ClientDeskTopManagementProgram_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            CheckRemainedTime();
            labelCDTMPRemainedTime.Text = ConvertIntToTime(remainedTime);
            labelCDTMPSitNo.Text = accessedSitID;
            labelCDTMPUserID.Text = "사용자 계정 : " + loginedRow[0]["user_id"].ToString();
            MessageBox.Show(accessedSitID);
        }

        private void button1_Click(object sender, EventArgs e) // 잔여시간 출력 테스트버튼
        {
            TestShowRemainedTime();
        }

        private void button2_Click(object sender, EventArgs e) // 잔여시간 차감 테스트버튼
        {
            UpdateRemainedTime();
        }

        private void ClientDeskTopManagementProgram_FormClosed(object sender, FormClosedEventArgs e) // 폼 닫힐 시 타이머를 종료
        {
            timer1.Stop();
        }

        private string ConvertIntToTime(int remainedTime) // 0~ 9분을 :00 ~ :09 로 보이기위한 변환함수
        {
            int hour = remainedTime / 60;
            int minute = remainedTime % 60;

            return $"{hour}:{minute:D2}";
        }

    }
}
