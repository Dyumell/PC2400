using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public class HookManager // 후킹을 위한 사용자 정의 클래스.
    {
        #region WindowsAPI 
        // 운영체제에 접근하기위한 논리적 그룹. ( alt + tab 은 운영체제에서 다루는 키조합, 이것을 가로채려면 아래의 dll 속성이 필요함. 
        // 이정도만 알아두고, 아래 코드는 이해하려고 하지말기. 나중에 따로 후킹에 대해 공부하는 걸 추천함
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private LowLevelKeyboardProc lowLevelKeyboardProc = HookProc;

        #endregion 
        // 운영체제에 접근하기위한 논리적 그룹. ( alt + tab 은 운영체제에서 다루는 키조합, 이것을 가로채려면 아래의 dll 속성이 필요함. 
        // 이정도만 알아두고, 아래 코드는 이해하려고 하지말기. 나중에 따로 후킹에 대해 공부하는 걸 추천함

        // 구조체 크기를 맞춰줘야 올바른 값을 받을 수 있습니다.
        // 메모리의 정렬과 패딩 문제.
        public struct HookStruct
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }

        // WM_Keydown
        // https://wiki.winehq.org/List_Of_Windows_Messages
        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int WM_SYSKEYDOWN = 0x0104;
        const int WM_SYSKEYUP = 0x0105;

        private static IntPtr hookId = IntPtr.Zero;

        public void SetHook() // 후킹하는 함수
        {
            IntPtr hInstance = LoadLibrary("User32");
            hookId = SetWindowsHookEx(WH_KEYBOARD_LL, lowLevelKeyboardProc, hInstance, 0);
        }

        public void UnHook()
        {
            UnhookWindowsHookEx(hookId);
        }

        public static IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                switch ((int)wParam)
                {
                    case WM_KEYDOWN:
                    case WM_KEYUP:
                    case WM_SYSKEYDOWN:
                    case WM_SYSKEYUP:
                        Keys key = (Keys)vkCode;
                        if ((key == Keys.Tab && (Control.ModifierKeys & Keys.Alt) == Keys.Alt) || //알탭
                            (key == Keys.Escape && (Control.ModifierKeys & Keys.Alt) == Keys.Alt) || //알익스케입
                            (key == Keys.F4 && (Control.ModifierKeys & Keys.Alt) == Keys.Alt) || //알엪4
                            (key == Keys.Escape && (Control.ModifierKeys & Keys.Control) == Keys.Control) || //컨트롤익스케입
                            (key == Keys.LWin) || (key == Keys.RWin)) //좌우윈도우
                        {
                            return (IntPtr)1; // 이 이벤트들은 처리하지말아라.
                        }
                        break;
                }
            }
            return CallNextHookEx(hookId, nCode, (int)wParam, lParam);
        }
    }
}
