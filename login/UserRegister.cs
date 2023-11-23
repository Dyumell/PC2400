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

/*
 *  개선요구사항 : (1)비밀번호 찿기 버튼, Twillo와 연동 (2)비밀번호에규칙추가 (3)전화번호중복허용X
 */

namespace login
{
    public partial class UserRegister : Form
    {

        // DataSet DS; 데이터베이스에서 복사한 데이터를 저장 할 변수
        // OracleCommandBuilder myCommandBuilder; 
        // OracleDataAdapter DBAdapter;
        // DataTable userTable; 테이블형태로 저장 할 변수

        public UserRegister()
        {
            InitializeComponent();
        }

        private void userRegisterConfirmBtn_Click(object sender, EventArgs e)
        {
            if (txtRegisterPwd.Text == txtRegisterPwdRe.Text)
            {
                try
                {
                    string connectionString = "User Id=dyumell; Password = 1755; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                    string commandString = "SELECT * FROM user_account_query"; // (1). 사용자계정 조회용 정보 에 튜플 추가를 위한 검색 sql
                    OracleDataAdapter DBAdapter
                        = new OracleDataAdapter(commandString, connectionString);

                    OracleCommandBuilder myCommandBuilder
                        = new OracleCommandBuilder(DBAdapter);
                    DataSet DS = new DataSet();

                    DBAdapter.Fill(DS, "user_account_query");
                    DataTable userTable = DS.Tables["user_account_query"]; // 사용자 정의 클래스로 계정정보 2종류를 찾는 걸 클래스화.

                    DataRow newRow;

                    newRow = userTable.NewRow(); // 하나의 새롭게 추가할 튜플에 대한 변수
                    newRow["user_id"] = txtRegisterID.Text;
                    newRow["user_pwd"] = txtRegisterPwd.Text;
                    newRow["user_name"] = txtRegisterName.Text;
                    newRow["user_phone_num"] = txtRegisterPhone.Text;
                    newRow["user_email"] = txtRegisterMail.Text;


                    userTable.Rows.Add(newRow); // 완성된 하나의 튜플, 복사본에 추가
                    DBAdapter.Update(DS, "user_account_query"); // 추가된 튜플을 DB에 업데이트

                    // (1) 사용자계정 조회용 정보 에 튜플 추가 완료

                    newRow.ItemArray = new object[userTable.Columns.Count]; // newRow의 초기화
                    userTable.Clear(); //userTable의 초기화

                    commandString = "SELECT * FROM user_account_login"; // (2). 로그인관련 사용자 계정정보에 튜플추가를 위한 검색 sql

                    DBAdapter = new OracleDataAdapter(commandString, connectionString);
                    myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                    DS.Clear(); // DS 초기화
                    DBAdapter.Fill(DS, "user_account_login"); // DS 에 user_Account_login의 복사본 저장

                    userTable = DS.Tables["user_account_login"];
                    newRow = userTable.NewRow();

                    newRow["user_id"] = txtRegisterID.Text;
                    newRow["remained_time"] = Convert.ToInt32(0); // 넘버형이니까 혹시 몰라서 이렇게 함.
                    newRow["user_type_code"] = "USER01"; // 이 3개의 컬럼은 기본값이 존재하는데, null로 지정된 경우에만 기본값으로 할당됨.
                    newRow["activation"] = "활성화"; // 그래서 기본값이 존재함에도 불구하고, not null 조건때문에 기본값을 이렇게 넣어주게된 것

                    userTable.Rows.Add(newRow);
                    DBAdapter.Update(DS, "user_account_login");

                    MessageBox.Show("계정이 성공적으로 생성됬습니다.");
                }
                catch (DataException DE)
                {
                    MessageBox.Show(DE.Message);
                }
                catch (Exception DE)
                {
                    MessageBox.Show(DE.Message);
                }

            }
            else
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다");
            }
        }
    }
}
