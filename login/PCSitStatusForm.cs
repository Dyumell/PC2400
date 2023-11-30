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
    public partial class PCSitStatusForm : Form
    {
        string command;
        string selectedSitNo;
        string selectedSitPower;
        string selectedSitMalfunction;
        SitManagementForm recievedData;


        public PCSitStatusForm(SitManagementForm sitManagermentForm)
        {

            InitializeComponent();

            recievedData = sitManagermentForm;

            // 자리관리폼에서 pc정보를 받아온다

            RecievePCSitInfo(recievedData);

            // 자리관리 폼에서 pc정보를 받아온다

            timer1.Start();

            // pc사용현황테이블에 접근하여 유저아이디와 잔여시간을 받아온다. *** 이 테이블 덕분에, 독립적인 프로그램들이 네트워킹됨.

            string command = "Select * From pc_sit_usage where pc_sit_id = :pc_sit_id";
            DBManager DBMSitStatus = new DBManager(command); // 커넥션정보를가짐. 
            DBMSitStatus.LetsUseParameter(); // 오라클 커넥션 객체 생성
            DBMSitStatus.Connection.Open(); // 데이터베이스에 연결

            DBMSitStatus.MyCommand = new OracleCommand(command, DBMSitStatus.Connection); // 오라클 커맨더 객체 생성
            DBMSitStatus.MyCommand.Parameters.Add("pc_user_id", OracleDbType.Varchar2, 30).Value = selectedSitNo; // 파라메터 사용

            DBMSitStatus.DataReader = DBMSitStatus.MyCommand.ExecuteReader(); // 쿼리문의 결과를 저장

            if (DBMSitStatus.DataReader.Read()) // 저장된 값이 존재하면 실행
            {
                txtLoginedUser.Text = DBMSitStatus.DataReader["user_id"].ToString();
                txtRemainedTime.Text = DBMSitStatus.DataReader["remained_time"].ToString();
            }

            DBMSitStatus.Connection.Close();

            // pc사용현황테이블에 접근하여 유저아이디와 잔여시간을 받아온다.

        }

        private void ForcedPowerOffBtn_Click(object sender, EventArgs e)
        {
            ShutDownTargetPC();
        }

        public void RecievePCSitInfo(SitManagementForm sitManagermentForm)
        {
            selectedSitNo = sitManagermentForm.SitIDArray[sitManagermentForm.SelectedSitNoIndex];
            selectedSitPower = sitManagermentForm.SitPowerArray[sitManagermentForm.SelectedSitNoIndex];
            selectedSitMalfunction = sitManagermentForm.SitMalfunctionArray[sitManagermentForm.SelectedSitNoIndex];
            txtSelectedSitNo.Text = selectedSitNo;
            txtSitPower.Text = selectedSitPower;
            txtSitMalfunction.Text = selectedSitMalfunction;
        }
        private void ShutDownTargetPC() //종료버튼 누를시 데이터베이스에 pc 꺼짐상태로 해놓음
        {

            command = "UPDATE PC_SIT_INFO SET PC_POWER = '꺼짐' WHERE PC_SIT_ID = :PC_SIT_ID";
            DBManager DBMPCSit = new DBManager(command);
            DBMPCSit.LetsUseParameter();
            DBMPCSit.Connection.Open();
            DBMPCSit.MyCommand = new OracleCommand(command, DBMPCSit.Connection);

            DBMPCSit.MyCommand.Parameters.Add("PC_SIT_ID", OracleDbType.Varchar2, 30).Value = selectedSitNo;

            DBMPCSit.MyCommand.ExecuteNonQuery();
            DBMPCSit.Connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RecievePCSitInfo(recievedData);
        }

        private void PCSitStatusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedSitNo);
        }
    }
}
