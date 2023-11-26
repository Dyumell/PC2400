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
using System.Net;


/*
 * 개선요구사항: ******* 이미 로그인 되었을시, 접근 거부 뜨는거. boolean 타입의 사용중여부 칼럼 추가 요망.
 */
namespace login
{
    public partial class LockedDeskTop: Form
    {
        string accessedSitID;
        string myIP = " 192.168.195.1";
        DataSet DS; // 복사된 데이터를 저장하는 변수
        OracleCommandBuilder myCommandBuilder; // 명령문을 자동으로 짜주는 도움이변수
        OracleDataAdapter DBAdapter; // 그거
        DataTable userTable; //추가될 Row(열)을 담아놓는 변수


        private HookManager hookManager = new HookManager(); // 잠금화면기능을 위한 훅매니져 객체 생성


        public string AccessedSitID
        {
            get { return accessedSitID; }
        }
        static string GetLocalIPAddress()
        {
            // 현재 PC의 모든 IP 주소를 가져옴
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            // 첫 번째 IP 주소를 반환
            return localIPs[0].ToString();
        }
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

            DataRow[] resultRows
            = userTable.Select("user_id = '" + txtLoginID.Text + "'");

            if (resultRows.Length > 0 && resultRows[0]["user_pwd"].ToString() == txtLoginPwd.Text) // 첫번쨰 조건. 검색한 user_id가 존재, 
            {                                                                                      // 두번쨰 조건 검색된 user_id의 user_pwd가 txtloginpwd와 일치 
               if (resultRows[0]["user_type_code"].ToString() == "USER03")
                {
                 
                    MessageBox.Show("주인이시여 명령을..!");
                    hookManager.UnHook(); // 반드시 사용종료시 훅을 종료
                    AdminDeskTopManagementProgram adminDeskTopManagementProgram = new AdminDeskTopManagementProgram(resultRows);
                    adminDeskTopManagementProgram.Show();
                    this.Hide(); // 잠금화면을 닫음, 사실 숨김.
                    adminDeskTopManagementProgram.FormClosed += (s, args) => this.Close(); // 새창이 꺼질시, 이 창도 같이 닫힘.
                }
                
                
                
                
                else if (Convert.ToInt32(resultRows[0]["remained_time"]) > 0) // Number 자료형은 Conver.ToInt32 로 형변환해야함.
                {
                    object userTypeCodeValue = resultRows[0]["user_type_code"];
                    string userTypeCodeString = userTypeCodeValue.ToString();
                    MessageBox.Show(userTypeCodeString);
                    hookManager.UnHook(); // 반드시 사용종료시 훅을 종료

                    string targetIpAddress = "192.168.58.1"; // PC001의 컴퓨터의 아이피
                    IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());


                    foreach (IPAddress ip in localIPs)
                    {
                        if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && ip.ToString() == targetIpAddress) // IP4v인지 확인,
                                                                                                                                   // 타겟주소인지 확인
                        {
                            accessedSitID = "PC001";
                        }
                    }

                    // 로그인된 피씨의 상태를 켜짐으로 전환
                    
                    DBManager sitSearch = new DBManager("select pc_sit_id,pc_power from pc_sit_info");
                    sitSearch.DBAdapter.Fill(sitSearch.DS, "pc_sit_info");
                    sitSearch.DTable = sitSearch.DS.Tables["pc_sit_info"];
                    sitSearch.ResultRows = sitSearch.DTable.Select("pc_sit_id = '" + accessedSitID + "'");

                    sitSearch.ResultRows[0]["pc_power"] = "켜짐";
      
                    sitSearch.TransactionOpen();

                    try
                    {
                        sitSearch.DBAdapter.SelectCommand.Transaction = sitSearch.Transaction;
                        sitSearch.DBAdapter.Update(sitSearch.DS, "pc_sit_info");
                        sitSearch.Transaction.Commit();
                    }
                    catch (DataException DE)
                    {
                        sitSearch.Transaction.Rollback();
                        throw DE;
                    }

                    // 로그인된 피씨의 상태를 켜짐으로 전환

                    ClientDeskTopManagementProgram clientDeskTopManagementProgram = new ClientDeskTopManagementProgram(resultRows,accessedSitID);
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

        private void connectTest_Click(object sender, EventArgs e) 
        {
            /*// 첫번째 행의 유저 아이디를 메세지박스로 출력하는 연결 확인용 버튼
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
            */
            string targetIpAddress = "192.168.58.1";
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());


            foreach (IPAddress ip in localIPs)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && ip.ToString() == targetIpAddress)
                {
                    accessedSitID = "PC001";
                }
            }
                MessageBox.Show(accessedSitID);
        }



    private void LockedDeskTop_FormClosed(object sender, FormClosedEventArgs e)
        {
            hookManager.UnHook(); //반드시 후킹을 풀어줘야한다

            // 로그아웃된 피씨의 상태를 꺼짐으로 전환

            DBManager sitSearch = new DBManager("select pc_sit_id,pc_power from pc_sit_info");
            sitSearch.DBAdapter.Fill(sitSearch.DS, "pc_sit_info");
            sitSearch.DTable = sitSearch.DS.Tables["pc_sit_info"];
            sitSearch.ResultRows = sitSearch.DTable.Select("pc_sit_id = '" + accessedSitID + "'");

            sitSearch.ResultRows[0]["pc_power"] = "꺼짐";

            sitSearch.TransactionOpen();

            try
            {
                sitSearch.DBAdapter.SelectCommand.Transaction = sitSearch.Transaction;
                sitSearch.DBAdapter.Update(sitSearch.DS, "pc_sit_info");
                sitSearch.Transaction.Commit();
            }
            catch (DataException DE)
            {
                sitSearch.Transaction.Rollback();
                throw DE;
            }

            // 로그아웃된 피씨의 상태를 꺼짐으로 전환
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

        private void button1_Click(object sender, EventArgs e) // 관리자 테스트를위한 로그인이 귀찮다

        {
            // 이걸 나중에 사용될 컴퓨터마다 할당해서 검색된 아이피와 일치하는 PC00* 번호 accessedSitID에 할당하게 재구현.
            string targetIpAddress = "192.168.58.1";
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            

            foreach (IPAddress ip in localIPs)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && ip.ToString() == targetIpAddress)
                {
                    accessedSitID = "PC001";
                }
            }
            // 이걸 나중에 사용될 컴퓨터마다 할당해서 검색된 아이피와 일치하는 PC00* 번호 accessedSitID에 할당하게 재구현.
            hookManager.UnHook(); // 반드시 사용종료시 훅을 종료
            DataRow[] resultRows = new DataRow[1];
            DataTable testTable = new DataTable();
            testTable.Columns.Add("user_id");
            resultRows[0] = testTable.NewRow();
            resultRows[0]["user_id"] = "이것은 관리자용 테스트 접근이다.";
            
            AdminDeskTopManagementProgram adminDeskTopManagementProgram = new AdminDeskTopManagementProgram(resultRows);
            adminDeskTopManagementProgram.Show();
            adminDeskTopManagementProgram.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)  // 고객 테스트를위한 로그인이 귀찮다
        {
            hookManager.UnHook(); // 반드시 사용종료시 훅을 종료

            string targetIpAddress = "192.168.58.1";
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());


            foreach (IPAddress ip in localIPs)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && ip.ToString() == targetIpAddress) // IP4v인지 확인,
                                                                                                                        // 타겟주소인지 확인
                {
                    accessedSitID = "PC001";
                }
            }
                DataRow[] resultRows = new DataRow[1];              
            DataTable testTable = new DataTable();
            testTable.Columns.Add("user_id");
            resultRows[0] = testTable.NewRow();
            resultRows[0]["user_id"] = "이것은 고객용 테스트 접근이다.";

            ClientDeskTopManagementProgram clientDeskTopManagementProgram = new ClientDeskTopManagementProgram(resultRows,accessedSitID);
            clientDeskTopManagementProgram.Show();
            clientDeskTopManagementProgram.FormClosed += (s, args) => this.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Server serverForm = new Server();
            serverForm.Show();
        }
    }
}
