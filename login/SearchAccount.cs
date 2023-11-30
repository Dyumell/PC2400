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


namespace login
{
    public partial class SearchAccount : Form
    {
        OracleDataAdapter DBAdapter;
        OracleCommandBuilder myCommandBuilder;
        DataSet DS;

        DataTable resultUserIDTable; // 검색버튼 4개에 의해 자주 쓰일 것
        DataRow[] resultRows; // 검색버튼 4개에 의해 자주 쓰일 것

        private string selectedUserID; // 선택된 사용자 ID를 저장하는 변수

        public SearchAccount()
        {
            DB_Open();
            InitializeComponent();
        }

        private void DB_Open() // DB연결
        {
            try
            {
                string connectionString = "User Id=chris; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
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

        private void SearchButtonClick(string columnName, TextBox textBox) // 검색 중복 내용 함수화
        {
            listViewSearchResult.Items.Clear(); // 리스트뷰 초기화
            DS.Clear(); // DS 초기화
            DBAdapter.Fill(DS, "JoinedData"); // DS에 쿼리한결과담음
            resultUserIDTable = DS.Tables["JoinedData"]; // 복사본을 DataTable 변수에 할당
            // resultRows : 할당된 테이블에서 쿼리를 적용하기 위한 DataRow변수 / DataRow[] 를 초기화할때는 Array.Clear(resultRow, 0, resultRow.length) 사용
            resultRows = resultUserIDTable.Select($"{columnName} like '%{textBox.Text}%'"); // ${} : 문자열 보간
                                                                                            // 문자열 보간 안에는 변수뿐만 아니라 모든 유효한 표현식을 넣을 수 있음

            foreach (DataRow dr in resultRows) // foreach문을 이용해서, 쿼리의 결과를 리스트뷰에 출력
            {
                ListViewItem item = new ListViewItem(dr[0].ToString()); // 첫 번째 열을 첫 번째 서브아이템으로 추가

                for (int i = 1; i < resultUserIDTable.Columns.Count; i++) // 만약 위처럼 첫번째열을 첫번째 서브아이템으로 추가하는 방식을
                                                                          // 사용하지 않을 시 리스트뷰가 전부 한칸씩 밀리게된다.
                {
                    item.SubItems.Add(dr[i].ToString());
                }

                listViewSearchResult.Items.Add(item);
            }
        }

        private void SearchUserID_Click(object sender, EventArgs e) // 아이디로 검색하기 버튼
        {
            SearchButtonClick("user_id", txtSearchUserID);
        }

        private void SearchUserNameBtn_Click(object sender, EventArgs e) // 이름으로 검색하기 버튼
        {
            SearchButtonClick("user_name", txtSearchUserName);
        }

        private void SearchUserPhoneBtn_Click(object sender, EventArgs e) // 전화번호로 검색하기 버튼
        {
            SearchButtonClick("user_phone_num", txtSearchUserPhoneNum);
        }

        private void SearchUserMailBtn_Click(object sender, EventArgs e) // 메일로 검색하기 버튼
        {
            SearchButtonClick("user_email", txtSearchUserMail);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSearchResult.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewSearchResult.SelectedIndices[0]; // 첫 번째 선택된 아이템의 인덱스
                ListViewItem selectedItem = listViewSearchResult.Items[selectedIndex]; // 선택된 아이템
                // string column1Value = selectedItem.SubItems[0].Text;
                // MessageBox.Show($"Selected: Column1 - {column1Value}");
                selectedUserID = selectedItem.SubItems[0].Text; // 선택한 사용자 ID 저장
                MessageBox.Show($"선택된 계정: 사용자 ID - {selectedUserID}");

            }
        }

        private void button2_Click(object sender, EventArgs e) // 사용내역조회버튼 -선행작업필요: 좌석관리디스플레이, 피시정보등
        {

        }

        private void button4_Click(object sender, EventArgs e) // 계정삭제버튼(삭제 완료 후 조회를 다시 하면 삭제된 데이터 리스트뷰에서 제거)
        {
            string deleteQuery = $"DELETE FROM user_account_login WHERE user_id = '{selectedUserID}'";
            if (!string.IsNullOrEmpty(selectedUserID))
            {
                try
                {
                    using (OracleConnection connection = new OracleConnection("User Id=chris; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));"))
                    {
                        connection.Open();

                        using (OracleCommand command = new OracleCommand(deleteQuery, connection))
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"계정 삭제 완료: 사용자 ID - {selectedUserID}");
                            }
                            else
                            {
                                MessageBox.Show($"계정 삭제 실패: 사용자 ID - {selectedUserID}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"계정 삭제 중 오류 발생: {ex.Message}");
                }

                selectedUserID = string.Empty;
            }
            else
            {
                MessageBox.Show("삭제할 계정을 선택하지 않았습니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e) // 계정 비밀번호 변경 버튼 --> 변경 폼 이동
        {
            if (!string.IsNullOrEmpty(selectedUserID))
            {
                // 비밀번호 변경 폼을 생성하고 표시
                ChangePwdForm changePasswordForm = new ChangePwdForm();
                DialogResult result = changePasswordForm.ShowDialog();

                // 사용자가 확인을 누른 경우
                if (result == DialogResult.OK)
                {
                    string newPassword = changePasswordForm.NewPassword;

                    // 데이터베이스에서 선택된 사용자의 비밀번호 업데이트
                    UpdatePassword(selectedUserID, newPassword);
                }
            }
            else
            {
                MessageBox.Show("비밀번호를 변경할 사용자를 선택하세요.");
            }
        }

        private void UpdatePassword(string userID, string newPassword) // 계정 비밀번호 업데이트 함수
        {
            try
            {
                string updateQuery = $"UPDATE user_account_query SET user_pwd = '{newPassword}' WHERE user_id = '{userID}'";

                using (OracleConnection connection = new OracleConnection("User Id=chris; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));"))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(updateQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"비밀번호 변경 완료: 사용자 ID - {userID}");
                        }
                        else
                        {
                            MessageBox.Show($"비밀번호 변경 실패: 사용자 ID - {userID}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비밀번호 변경 중 오류 발생: {ex.Message}");
            }
        }
    }
}

