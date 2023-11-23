using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class AdminDeskTopManagementProgram : Form
    {
        DataRow[] loginedRow; // 로그인한 계정정보를 넘겨받기위한 변수
        public AdminDeskTopManagementProgram(DataRow[] resultRows) // 로그인한 계정정보를 넘겨받는 생성자
        {
            
            InitializeComponent();
            DisableCloseButton(this.Handle); // 이거 순서 잘못놓으면 작동 안하더라;;
            this.loginedRow = resultRows; //넘겨받음
        }

        #region WindowsAPI
        //관리자데스크탑관리프로그램 또한 종료되면 안된다.
        //이를 위해 닫기 버튼을 비활성화한다.
        [DllImport("user32.dll")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        public static extern int EnableMenuItem(IntPtr hWnd, uint uIDEnableItem, uint Enable);

        private const int SC_CLOSE = 0xF060;
        private const int MF_GRAYED = 0x0001;
        private const int MF_BYCOMMAND = 0x0000;
        #endregion

        private void DisableCloseButton(IntPtr handle)
        {
            // 시스템 메뉴 핸들 가져오기
            IntPtr hMenu = GetSystemMenu(handle, false);

            // 닫기 버튼 비활성화
            EnableMenuItem(hMenu, SC_CLOSE, MF_GRAYED);
        }

        private void AdminDeskTopManagementProgramEmergencyExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestADTMPRecievedDataBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그인된 관리자 계정은 " + loginedRow[0]["user_id"] + " 입니다");
        }

        private void AdminDeskTopManagementProgram_Load(object sender, EventArgs e)
        {
            labelADTMPUserID.Text = "관리자계정 : " + loginedRow[0]["user_id"].ToString();
        }

        private void SearchAccountBtn_Click(object sender, EventArgs e)
        {
            //!! 성격이 다른 ( 함수, 변수 ) 를 하나로 묶어주는 것을 클래스라함.
            SearchAccount searchAccount = new SearchAccount();
            searchAccount.Show();
        }

        private void SitManagementBtn_Click(object sender, EventArgs e)
        {
            SitManagementForm sitManagementForm = new SitManagementForm();
            sitManagementForm.Show();
        }
    }
}
