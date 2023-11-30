using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test1
{

    public partial class MeneuOrderListQueueForm : Form
    {

        #region WindowsAPI 
        //주문접수는 끊임 없이 이루어지고, 신속하게 확인할수혹 고객 만족도가 높아진다.
        //이를위해 닫기버튼을 비활성화한다.
        [DllImport("user32.dll")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        public static extern int EnableMenuItem(IntPtr hWnd, uint uIDEnableItem, uint Enable);

        private const int SC_CLOSE = 0xF060;
        private const int MF_GRAYED = 0x0001;
        private const int MF_BYCOMMAND = 0x0000;
        #endregion

        string command;

        // 주문번호, 아이디, 좌석번호, 주문메뉴, 가격을 저장할 리스트
        List<int> orderNumbers = new List<int>();
        List<string> userIDs = new List<string>();
        List<string> pcSitIDs = new List<string>();
        List<string> menuNames = new List<string>();
        List<Int32> menuCosts = new List<Int32>();
        List<string> orderTimes = new List<string>();

        public MeneuOrderListQueueForm()
        {
            InitializeComponent();
            DisableCloseButton(this.Handle);
        }

        public void SetLists()
        {
            command = "SELECT " +
                    "MOL.USER_ID," + // 주문한 사용자명
                    "MOL.PC_SIT_ID," + // 주문한 사용자명
                    "MOL.MENU_ID," + // 주문한 항목코드
                    "MI.MENU_NAME," + // 주문한 항목이름
                    "MI.MENU_COST," + // 주문한 항목가격
                    "MOL.ORDER_DONE," + // 주문처리상태
                    "TO_CHAR(MOL.MENU_ORDER_TIME, 'YYYY-MM-DD HH24:MI') AS ORDER_TIME " + // 주무한 시간 ( 00:00:00 으로 표시 )
                    "FROM MENU_ORDER_LOG MOL " +
                    "JOIN MENU_INFO MI " +
                    "ON MOL.MENU_ID = MI.MENU_ID";

            DBManager DBMOrderQ = new DBManager(command);
            DBMOrderQ.DBAdapter.Fill(DBMOrderQ.DS, "MenuOrderJoined");
            DBMOrderQ.DTable = DBMOrderQ.DS.Tables["MenuOrderJoined"];

            DBMOrderQ.ResultRows = DBMOrderQ.DTable.Select("ORDER_DONE = '주문처리중'");

            ClearList();

            foreach (DataRow row in DBMOrderQ.ResultRows)
            {
                string orderTime = row["ORDER_TIME"].ToString();
                int existingIndex = orderTimes.FindIndex(t => t == orderTime);

                // 감지되는 첫번쨰 인덱스를 반환

                string menuName = row["MENU_NAME"].ToString();
                Int32 menuCost = Convert.ToInt32(row["MENU_COST"]);

                if (existingIndex != -1) // orderTimes 리스트에 투가하려했던 시간대가 존재하고 있을시.
                {
                    menuNames[existingIndex] += ", " + menuName; // 주문한 시간대 동일시 해당 요소에 추가
                    menuCosts[existingIndex] += menuCost;
                }
                else // 중복되는 시간이 없다면  각 리스트별 새로운 요소를 생성
                {
                    int orderNumber = (orderNumbers.Count + 1);
                    orderNumbers.Add(orderNumber);

                    string userID = row["USER_ID"].ToString();
                    userIDs.Add(userID);

                    string pcSitID = row["PC_SIT_ID"].ToString();
                    pcSitIDs.Add(pcSitID);

                    menuNames.Add(menuName);
                    menuCosts.Add(menuCost);
                    orderTimes.Add(orderTime);
                }
            }
        }

        public void UpdateList()
        {
            OrderListView.Items.Clear();

            for (int i = 0; i < orderNumbers.Count; i++)
            {

                ListViewItem item = new ListViewItem(orderNumbers[i].ToString());

                item.SubItems.Add(pcSitIDs[i]);
                item.SubItems.Add(userIDs[i]);
                item.SubItems.Add(menuNames[i]);
                item.SubItems.Add(menuCosts[i].ToString());
                item.SubItems.Add(orderTimes[i].ToString());

                OrderListView.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OrderListView.Items.Clear();
            SetLists();
            UpdateList();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 아이디와 날짜가 일치한 튜플들의 주문처리상태전환
            command = "UPDATE MENU_ORDER_LOG " +
            "SET ORDER_DONE = '처리완료' " +
            "WHERE USER_ID = :USER_ID " +
            "AND TO_CHAR(MENU_ORDER_TIME, 'YYYY-MM-DD HH24:MI') = :MENU_ORDER_TIME";

            DBManager DBMOrderQ = new DBManager(command);
            DBMOrderQ.LetsUseParameter();
            DBMOrderQ.Connection.Open();
            DBMOrderQ.MyCommand = new OracleCommand(command, DBMOrderQ.Connection);

            DBMOrderQ.MyCommand.Parameters.Add("USER_ID", OracleDbType.Varchar2, 30).Value = column3Value;
            DBMOrderQ.MyCommand.Parameters.Add("MENU_ORDER_TIME", OracleDbType.Varchar2, 16).Value = column6Value;

            DBMOrderQ.MyCommand.ExecuteNonQuery();

            DBMOrderQ.Connection.Close();
        }

        string column3Value;

        string column6Value;

        private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 항목이 있는지 확인
            if (OrderListView.SelectedItems.Count > 0)
            {
                // 선택된 항목 가져오기
                ListViewItem selectedItem = OrderListView.SelectedItems[0];

                // 각 열의 값을 가져오기
                string column1Value = selectedItem.SubItems[0].Text;
                string column2Value = selectedItem.SubItems[1].Text;
                column3Value = selectedItem.SubItems[2].Text;
                string column4Value = selectedItem.SubItems[3].Text;
                string column5Value = selectedItem.SubItems[4].Text;
                column6Value = selectedItem.SubItems[5].Text;

                // 메시지 구성
                StringBuilder messageBuilder = new StringBuilder();
                messageBuilder.AppendLine($"주문번호 : {column1Value}");
                messageBuilder.AppendLine($"주문 좌석: {column2Value}");
                messageBuilder.AppendLine($" 주문자  : {column3Value}");
                messageBuilder.AppendLine($"주문내용 : {column4Value}");
                messageBuilder.AppendLine($"주문금액 : {column5Value}");
                messageBuilder.AppendLine($"주문시간 : {column6Value}");

                // 메시지 박스에 출력
                TextMenuDescription.Text = (messageBuilder.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 아이디와 날짜가 일치한 튜플들의 삭제
            command = "DELETE FROM MENU_ORDER_LOG " +
            "WHERE USER_ID = :USER_ID " +
            "AND TO_CHAR(MENU_ORDER_TIME, 'YYYY-MM-DD HH24:MI') = :MENU_ORDER_TIME";

            DBManager DBMOrderQ = new DBManager(command);
            DBMOrderQ.LetsUseParameter();
            DBMOrderQ.Connection.Open();
            DBMOrderQ.MyCommand = new OracleCommand(command, DBMOrderQ.Connection);

            DBMOrderQ.MyCommand.Parameters.Add("USER_ID", OracleDbType.Varchar2, 30).Value = column3Value;
            DBMOrderQ.MyCommand.Parameters.Add("MENU_ORDER_TIME", OracleDbType.Varchar2, 16).Value = column6Value;

            DBMOrderQ.MyCommand.ExecuteNonQuery();

            DBMOrderQ.Connection.Close();

        }

        public void ClearList()
        {
            orderNumbers.Clear();
            userIDs.Clear();
            pcSitIDs.Clear();
            menuNames.Clear();
            menuCosts.Clear();
            orderTimes.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OrderListView.Items.Clear();
            SetLists();
            UpdateList();
        }

        private void MeneuOrderListQueueForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void DisableCloseButton(IntPtr handle)
        {
            // 시스템 메뉴 핸들 가져오기
            IntPtr hMenu = GetSystemMenu(handle, false);

            // 닫기 버튼 비활성화
            EnableMenuItem(hMenu, SC_CLOSE, MF_GRAYED);
        }

        private void MeneuOrderListQueueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}