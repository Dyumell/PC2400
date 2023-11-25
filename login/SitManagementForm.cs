using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace login
{
    public partial class SitManagementForm : Form
    {
        static string command = "SELECT user_id,remained_time FROM user_account_login";
        DBManager DBMSit = new DBManager(command);
        // PC_Sit_ID  를 검색후 버튼1(PC001) 에 할당, 파워상태, 작동상태 변수를 생성후 DB와연결.
        // CDTMP 에서 폼 로드시 pc_sit변수 를 PC_Sit_ID에 해당하는 버튼의 색을 변경시킴. remainedtime을 공유함. userid를 공유함. 
        // 위의 기믹에서 pc고유번호의 값과 user_id 의 값을 동시에 저장하고, 종료해서 pc고유번호 초기화전 해당 user_id에 
        // pc 고유번호 변경이 감지될시, 접근을 차단하는 기능을 구현하면 동일계정의 동시접속을 막을 수 있음.
        // 테두리 하얀거 제거하고싶음.


        public SitManagementForm()
        {
            InitializeComponent(); 
        }

        private void SitNo1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
