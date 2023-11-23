using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace login
{
    public partial class SearchAccount : Form
    {
        OracleDataAdapter DBAdapter;
        OracleCommandBuilder myCommandBuilder;
        DataSet DS;

        public SearchAccount()
        {
            DB_Open();
            InitializeComponent();
        }

        private void DB_Open() // DB연결
        {
            try
            {
                string connectionString = "User Id=dyumell; Password = 1755; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString =
                    "SELECT user_account_login.user_id, user_name, user_phone_num, user_email, user_pwd FROM user_account_login " +
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "JoinedData");
            DataTable resultTable = DS.Tables["JoinedData"];
            DataRowCollection rows = resultTable.Rows;

            foreach (DataRow dr in rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < resultTable.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                listView1.Items.Add(item);

            }
        }
    }
}
