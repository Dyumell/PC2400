using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class ChangePwdForm : Form
    {
        public string NewPassword { get; private set; }

        public ChangePwdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 비밀번호 변경 버튼 --> 비밀번호 변경 물음 --> 변경 or 취소
        {
            // 새로운 비밀번호를 가져와서 설정
            NewPassword = changepwd.Text;

            // 변경 여부 다시 확인
            DialogResult confirmResult = MessageBox.Show("정말 비밀번호를 변경하시겠습니까?", "비밀번호 변경 확인", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // 변경 확인 처리
                DialogResult = DialogResult.OK;

                // 폼 닫기
                Close();
            }
            
            // NO 선택시 버튼을 누르기 전상태 --> 여전히 변경버튼 or 취소버튼을 누를 수 있음
        }

        private void button2_Click(object sender, EventArgs e) // 취소 버튼 --> 비밀번호 변경 폼 종료
        {
            // 취소 처리
            DialogResult = DialogResult.Cancel;

            // 폼 닫기
            Close();
        }
    }
}
