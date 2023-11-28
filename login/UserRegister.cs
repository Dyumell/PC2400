using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

/*
 *  개선요구사항 : (1)비밀번호 찿기 버튼, Twillo와 연동 (2)비밀번호에규칙추가 (3)전화번호중복허용X
 *  회원가입이 완료되면 회원가입폼 종료 하는 코드 추가
 *  비밀번호 유효성검사하는 코드 추가(비밀번호는 영문 대/소문자, 숫자, 특수문자를 포함하여 8자 이상)
 *  전화번호 중복허용하지 않는 코드 추가
 *  비밀번호확인 텍스트박스 마우스 커서 올리면 보이고 내리면 *표시로 숨기는 코드 추가
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
            txtRegisterPwdRe.UseSystemPasswordChar = true; // 비밀번호 확인란 '*' 표시

            // MouseEnter 이벤트 핸들러 추가
            txtRegisterPwdRe.MouseEnter += TxtRegisterPwdRe_MouseEnter;
            // MouseLeave 이벤트 핸들러 추가
            txtRegisterPwdRe.MouseLeave += TxtRegisterPwdRe_MouseLeave;
        }

        /**
        private void userRegisterConfirmBtn_Click(object sender, EventArgs e)
        {
            if (txtRegisterPwd.Text == txtRegisterPwdRe.Text)
            {
                try
                {
                    string connectionString = "User Id=chris; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
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

                    this.Close(); // 추가된 부분 --> 회원가입이 성공하면 폼을 종료
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
        **/

        private void userRegisterConfirmBtn_Click(object sender, EventArgs e)
        {
            if (txtRegisterPwd.Text == txtRegisterPwdRe.Text)
            {
                if (IsPasswordValid(txtRegisterPwd.Text))
                {
                    if (!IsPhoneNumberDuplicate(txtRegisterPhone.Text))
                    {
                        try
                        {
                            string connectionString = "User Id=chris; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); ";
                            string commandString = "SELECT * FROM user_account_query";
                            OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                            OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                            DataSet DS = new DataSet();

                            DBAdapter.Fill(DS, "user_account_query");
                            DataTable userTable = DS.Tables["user_account_query"];

                            DataRow newRow = userTable.NewRow();
                            newRow["user_id"] = txtRegisterID.Text;
                            newRow["user_pwd"] = txtRegisterPwd.Text;
                            newRow["user_name"] = txtRegisterName.Text;
                            newRow["user_phone_num"] = txtRegisterPhone.Text;
                            newRow["user_email"] = txtRegisterMail.Text;

                            userTable.Rows.Add(newRow);
                            DBAdapter.Update(DS, "user_account_query");

                            newRow.ItemArray = new object[userTable.Columns.Count];
                            userTable.Clear();

                            commandString = "SELECT * FROM user_account_login";
                            DBAdapter = new OracleDataAdapter(commandString, connectionString);
                            myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                            DS.Clear();
                            DBAdapter.Fill(DS, "user_account_login");

                            userTable = DS.Tables["user_account_login"];
                            newRow = userTable.NewRow();

                            newRow["user_id"] = txtRegisterID.Text;
                            newRow["remained_time"] = Convert.ToInt32(0);
                            newRow["user_type_code"] = "USER01";
                            newRow["activation"] = "활성화";

                            userTable.Rows.Add(newRow);
                            DBAdapter.Update(DS, "user_account_login");

                            MessageBox.Show("계정이 성공적으로 생성되었습니다.");

                            this.Close(); // 회원가입이 성공하면 폼을 종료
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
                        MessageBox.Show("이미 등록된 전화번호입니다.");
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호는 영문 대/소문자, 숫자, 특수문자를 포함하여 8자 이상이어야 합니다.");
                }
            }
            else
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
        }

        // 비밀번호 유효성 검사 메서드
        private bool IsPasswordValid(string password)
        {
            // 비밀번호는 영문 대/소문자, 숫자, 특수문자를 포함하여 8자 이상이어야 함
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        // 전화번호 중복 여부 확인 메서드
        private bool IsPhoneNumberDuplicate(string phoneNumber)
        {
            // 여기에 데이터베이스에서 전화번호 중복 여부를 확인하는 로직을 추가
            // 필요에 따라 Oracle 데이터베이스 연동 코드를 작성
            // 예시: SELECT COUNT(*) FROM user_account_query WHERE user_phone_num = :phoneNumber
            return false; // 임시로 false를 반환하도록 설정 (실제 데이터베이스 연동 필요)
        }

        private void TxtRegisterPwdRe_MouseEnter(object sender, EventArgs e)
        {
            // 마우스가 텍스트박스에 들어왔을 때, 비밀번호를 보여줌
            txtRegisterPwdRe.UseSystemPasswordChar = false;
        }

        private void TxtRegisterPwdRe_MouseLeave(object sender, EventArgs e)
        {
            // 마우스가 텍스트박스에서 나갔을 때, '*'로 숨김
            txtRegisterPwdRe.UseSystemPasswordChar = true;
        }
    }
}
