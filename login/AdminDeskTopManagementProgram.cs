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
        public AdminDeskTopManagementProgram()
        {
            
            InitializeComponent();
            DisableCloseButton(this.Handle); // 이거 순서 잘못놓으면 작동 안하더라;;
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

    }
}
