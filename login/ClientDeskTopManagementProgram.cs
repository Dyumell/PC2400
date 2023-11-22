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
    public partial class ClientDeskTopManagementProgram : Form
    {
        private DataRow[] loginedRow;
        public ClientDeskTopManagementProgram(DataRow[] resultRows) // 로그인된 계정정보를 받기위한 생성자
        {
            InitializeComponent();
            DisableCloseButton(this.Handle);
            this.loginedRow = resultRows;
                }

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
    }
}
