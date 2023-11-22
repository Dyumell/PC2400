using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


/*
 * 개선요구사항: 잠금화면 구현.
 */
namespace login
{
    public partial class LockedDeskTop: Form
    {
        DataSet DS; // 복사된 데이터를 저장하는 변수
        OracleCommandBuilder myCommandBuilder; // 명령문을 자동으로 짜주는 도움이변수
        OracleDataAdapter DBAdapter; // 그거
        DataTable userTable; //추가될 Row(열)을 담아놓는 변수


        private HookManager hookManager = new HookManager(); // 잠금화면기능을 위한 훅매니져 객체 생성


        private void DB_Open() // DB연결
        {
            try
            {
                string connectionString = "User Id=dyumell; Password = 1755; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = 
                    "SELECT * FROM user_account_login " +
                    "INNER JOIN user_account_query " +
                    "ON user_account_login.user_id = user_account_query.user_id";   // 로그인전용 사용자 계정 정보와 조회용 사용자 계정정보를 
                                                                                    // 유저 아이디를 기준으로 내부조인하여 셀렉트하는 sql 
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        
        public LockedDeskTop()
        {
            DB_Open();
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockedDeskTop_FormClosed); //폼이 닫힐 시, 폼클로즈함수 실행
            hookManager.SetHook(); // 훅이 실행됨. 
        }

        private void SearchPwdBtn_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void userRegisterBtn_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "user_account_login");
            userTable = DS.Tables["user_account_login"];

            DataRow[] ResultRows
            = userTable.Select("user_id = '" + txtLoginID.Text + "'");

            if (ResultRows.Length > 0 && ResultRows[0]["user_pwd"].ToString() == txtLoginPwd.Text)
            {
                if (Convert.ToInt32(ResultRows[0]["remained_time"]) > 0) // Number 자료형은 Conver.ToInt32 로 형변환해야함.
                {
                    MessageBox.Show("환영합니다");
                    hookManager.UnHook(); // 반드시 사용종료시 훅을 종료

                    ClientDeskTopManagementProgram clientDeskTopManagementProgram = new ClientDeskTopManagementProgram();
                    clientDeskTopManagementProgram.Show();
                    this.Hide(); // 잠금화면을 닫음, 사실 숨김.
                    clientDeskTopManagementProgram.FormClosed += (s, args) => this.Close(); // 새창이 꺼질시, 이 창도 같이 닫힘.

                }

                else
                {
                    MessageBox.Show("잔여시간이 부족합니다");
                }

            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다");
            }

        }

        private void connectTest_Click(object sender, EventArgs e) // 첫번째 행의 유저 아이디를 메세지박스로 출력하는 연결 확인용 버튼
        {
            DS.Clear();  // DS가 차있으니 초기화
            DBAdapter.Fill(DS, "user_account_login"); // DS에 로그인전용 사용자 계정 정보의 복사본을 저장

            // DataTable 가져오기
            userTable = DS.Tables["user_account_login"];

            // 첫 번째 행의 user_id 가져오기
            if (userTable != null && userTable.Rows.Count > 0)
            {
                string userId = userTable.Rows[0]["user_id"].ToString();

                // 메시지 박스에 출력
                MessageBox.Show($"검색된 유저 아이디: {userId}");
            }
            else
            {
                MessageBox.Show("검색된 유저 아이디가 없습니다.");
            }
        }

        

        private void LockedDeskTop_FormClosed(object sender, FormClosedEventArgs e)
        {
            hookManager.UnHook(); //반드시 후킹을 풀어줘야한다
        }

        private void LockedDeskTop_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; // 윈도우 테두리 없음
            this.WindowState = FormWindowState.Maximized; // 최대화
        }

        private void emergencyExit_Click(object sender, EventArgs e)
        {
            Close(); // 테스트용 종료
        }
    }
}
