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

        DataTable resultUserIDTable; // 검색버튼 4개에 의해 자주 쓰일 것
        DataRow[] resultRows; // 검색버튼 4개에 의해 자주 쓰일 것

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


        private void SearchUserID_Click(object sender, EventArgs e) // 아이디로 검색하기 버튼
        {
            listViewSearchResult.Items.Clear(); // 리스트뷰 초기화
            DS.Clear(); // DS 초기화
            DBAdapter.Fill(DS, "JoinedData"); // DS에 쿼리한결과담음
            resultUserIDTable = DS.Tables["JoinedData"]; // 복사본을 DataTable 변수에 할당
            resultRows // 할당된 테이블에서 쿼리를 적용하기 위한 DataRow변수
            = resultUserIDTable.Select("user_id like '%" + txtSearchUserID.Text + "%'"); // DataRow[] 를 초기화할때는 Array.Clear(resultRow, 0, resultRow.length) 사용



            foreach (DataRow dr in resultRows) // foreach문을 이용해서, 쿼리의 결과를 리스트뷰에 출력
            {
                ListViewItem item = new ListViewItem(dr[0].ToString()); // 첫 번째 열을 첫 번째 서브아이템으로 추가

                // 나머지 열에 대해 서브아이템 추가
                for (int i = 1; i < resultUserIDTable.Columns.Count; i++) // 만약 위처럼 첫번째열을 첫번째 서브아이템으로 추가하는 방식을 
                {                                                         // 사용하지 않을 시 리스트뷰가 전부 한칸씩 밀리게된다.
                    item.SubItems.Add(dr[i].ToString());
                }

                listViewSearchResult.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSearchResult.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewSearchResult.SelectedIndices[0]; // 첫 번째 선택된 아이템의 인덱스
                ListViewItem selectedItem = listViewSearchResult.Items[selectedIndex]; // 선택된 아이템
                string column1Value = selectedItem.SubItems[0].Text;

                MessageBox.Show($"Selected: Column1 - {column1Value}");

            }
        }

        private void SearchUserNameBtn_Click(object sender, EventArgs e)
        {
            listViewSearchResult.Items.Clear();
            DS.Clear();
            DBAdapter.Fill(DS, "JoinedData");
            resultUserIDTable = DS.Tables["JoinedData"];
            resultRows
    = resultUserIDTable.Select("user_name like '%" + txtSearchUserName.Text + "%'");

            foreach (DataRow dr in resultRows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString()); // 첫 번째 열을 첫 번째 서브아이템으로 추가

                // 나머지 열에 대해 서브아이템 추가
                for (int i = 1; i < resultUserIDTable.Columns.Count; i++) // 만약 위처럼 첫번째열을 첫번째 서브아이템으로 추가하는 방식을 
                {                                                         // 사용하지 않을 시 리스트뷰가 전부 한칸씩 밀리게된다.
                    item.SubItems.Add(dr[i].ToString());
                }

                listViewSearchResult.Items.Add(item);
            }
        }

        private void SearchUserPhoneBtn_Click(object sender, EventArgs e)
        {
            listViewSearchResult.Items.Clear();
            DS.Clear();
            DBAdapter.Fill(DS, "JoinedData");
            resultUserIDTable = DS.Tables["JoinedData"];
            resultRows
    = resultUserIDTable.Select("user_phone_num like '%" + txtSearchUserPhoneNum.Text + "%'");

            foreach (DataRow dr in resultRows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString()); // 첫 번째 열을 첫 번째 서브아이템으로 추가

                // 나머지 열에 대해 서브아이템 추가
                for (int i = 1; i < resultUserIDTable.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }

                listViewSearchResult.Items.Add(item);

            }
        }

        private void SearchUserMailBtn_Click(object sender, EventArgs e)
        {
            listViewSearchResult.Items.Clear();
            DS.Clear();
            DBAdapter.Fill(DS, "JoinedData");
            resultUserIDTable = DS.Tables["JoinedData"];
            resultRows
                        = resultUserIDTable.Select("user_email like '%" + txtSearchUserMail.Text + "%'");
                foreach (DataRow dr in resultRows)
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString()); // 첫 번째 열을 첫 번째 서브아이템으로 추가

                    // 나머지 열에 대해 서브아이템 추가
                    for (int i = 1; i < resultUserIDTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }

                    listViewSearchResult.Items.Add(item);

                }
            }

        private void button2_Click(object sender, EventArgs e) //  사용내역조회버튼 -선행작업필요: 좌석관리디스플레이, 피시정보등
        {

        }
    }
    }

