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
        string[] sitPowerOn = new string[70];

        string[] sitIDArray = new string[70]; // 피시좌석 아이디 저장할 배열
        string[] sitPowerArray = new string[70]; // 피시 파워상태 저장 배열
        string[] sitMalfunctionArray = new string[70]; // 피시 고장상태 저장 배열


        int selectedSitNoIndex; /// 팦업 폼의 배열에 쓸 인덱스.

        string controlName; // 버튼을 탐색할 때 쓸 변수;

        public string[] SitIDArray { get { return sitIDArray; } set { sitIDArray = value; } }
        public string[] SitPowerArray { get { return sitPowerArray; } set { sitPowerArray = value; } }


        public string[] SitMalfunctionArray { get { return sitMalfunctionArray; } set { sitMalfunctionArray = value; } }

        public int SelectedSitNoIndex { get { return selectedSitNoIndex; } set { selectedSitNoIndex = value; } }

        string[] sitRemainedTime = new string[70];
        
        public string[] SitRemainedTime { get { return sitRemainedTime; } set { sitRemainedTime = value; } }




        static string command = "SELECT * FROM pc_sit_info";

        public void SetSitNo()
        {
            DBManager DBMSit = new DBManager(command);
            DBMSit.DBAdapter.Fill(DBMSit.DS, "pc_sit_info");
            DBMSit.DTable = DBMSit.DS.Tables["pc_sit_info"];

            DBMSit.ResultRows = DBMSit.DTable.Select();

            // MessageBox.Show(DBMSit.ResultRows[0]["pc_sit_id"].ToString() + " " + DBMSit.ResultRows[1]["pc_sit_id"].ToString()); // 배열 일 잘하네
            for (int i = 0; i < 70; i++)
            {
                SitIDArray[i] = DBMSit.ResultRows[i]["pc_sit_id"].ToString();    // ResultRow안에든건 object 형임.
                SitPowerArray[i] = DBMSit.ResultRows[i]["pc_power"].ToString();
                SitMalfunctionArray[i] = DBMSit.ResultRows[i]["pc_malfunction"].ToString();
            }

        }


        public void SitColorized()
        {
            // 버튼의 색 적용을 위한 전원상태, 고장상태 가져오는 코드
            DBManager DBMSit = new DBManager("select pc_power, pc_malfunction from pc_sit_info");
            DBMSit.DBAdapter.Fill(DBMSit.DS, "pc_sit_info");
            DBMSit.DTable = DBMSit.DS.Tables["pc_sit_info"];

            DBMSit.ResultRows = DBMSit.DTable.Select();
            for (int i = 0; i < 70; i++)
            {
                if (DBMSit.ResultRows.Length > i) // 배열 길이 확인
                {
                    SitPowerArray[i] = DBMSit.ResultRows[i]["pc_power"].ToString();
                    SitMalfunctionArray[i] = DBMSit.ResultRows[i]["pc_malfunction"].ToString();
                }
                else
                {
                    // 디버깅 메시지 출력
                    Console.WriteLine($"Error: No data for index {i} in pc_sit_info");
                }
            }

            // 라벨에 할당 할 잔여시간 가져오는 코드
            DBManager DBMSitUsage = new DBManager("select remained_time from pc_sit_usage");
            DBMSitUsage.DBAdapter.Fill(DBMSitUsage.DS, "remaindedTime");
            DBMSitUsage.DTable = DBMSitUsage.DS.Tables["remaindedTime"];

            DBMSitUsage.ResultRows = DBMSitUsage.DTable.Select();

            int loopCount = Math.Min(70, DBMSitUsage.ResultRows.Length);

            for (int i = 0; i < loopCount; i++)
            {
                SitRemainedTime[i] = DBMSitUsage.ResultRows[i]["remained_time"].ToString();
            }
                // 라벨에 할당 할 잔여시간 가져오는  코드

                for (int i = 0; i < 70; i++)
            {
                if (SitPowerArray[i] == "켜짐") // 조인해서 피시좌석번호( pc_sit_id) , 피시전원상태 (pc_power)  ,피시고장상태 (pc_malfunction)
                                                // 받아서 변수에 저장하고, pc_sit_id 에 저장된 001 부분만 추출해서, 라벨 NAME과 일치한경우 라벨이 visable 
                                                // 하게하면 되는데, 시간이 부족해서 구현은 못하겠음.ㄴ
                {
                    controlName = "SitNo" + (i + 1);
                    sitPowerOn[i] = controlName;


                    Control[] foundControls = this.Controls.Find(controlName, true);
                    if (foundControls.Length > 0 && foundControls[0] is Button)
                    {
                        Button targetButton = (Button)foundControls[0];
                        targetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(241)))));
                        targetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
                    }

                    controlName = "SitRemaindedTime" + (i + 1);

                    foundControls = this.Controls.Find(controlName, true);
                    if (foundControls.Length > 0 && foundControls[0] is Label)
                    {
                        Label targetLabel = (Label)foundControls[0];
                        targetLabel.Text = sitRemainedTime[i].ToString();
                        targetLabel.Visible = true;
                    }
                }

                if (sitPowerOn[i] == "꺼짐")
                {
                    controlName = "SitNo" + (i + 1);
                    Control[] foundControls = this.Controls.Find(controlName, true);
                    if (foundControls.Length > 0 && foundControls[0] is Button)
                    {
                        Button targetButton = (Button)foundControls[0];
                        targetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(191))))); ;
                        targetButton.ForeColor = Color.Black;
                    }
                    controlName = "SitRemaindedTime" + (i + 1);
                    foundControls = this.Controls.Find(controlName, true);
                    if (foundControls.Length > 0 && foundControls[0] is Label)
                    {
                        Label targetLabel = (Label)foundControls[0];
                        targetLabel.Text = "00:00";
                        targetLabel.Visible = false;
                    }

                }

            }
        }



        // PC_Sit_ID  를 검색후 버튼1(PC001) 에 할당, 파워상태, 작동상태 변수를 생성후 DB와연결.
        // CDTMP 에서 폼 로드시 pc_sit변수 를 PC_Sit_ID에 해당하는 버튼의 색을 변경시킴. remainedtime을 공유함. userid를 공유함. 
        // 위의 기믹에서 pc고유번호의 값과 user_id 의 값을 동시에 저장하고, 종료해서 pc고유번호 초기화전 해당 user_id에 
        // pc 고유번호 변경이 감지될시, 접근을 차단하는 기능을 구현하면 동일계정의 동시접속을 막을 수 있음.
        // 테두리 하얀거 제거하고싶음.

        // 26 일요일날 해야할거. 로그인시 피시 좌석 정보에 켜짐 상태 만들기. 폼 꺼질때 꺼짐 상태로 변경하게하기.


        public SitManagementForm()
        {
            SetSitNo();
            InitializeComponent(); 
        }

        private void InitializeSits()
        {
            for(int i = 1; i <= sitIDArray.Length; i++) // 버튼 70개에 일괄 동일 작업할당
            {
                string controlName = "SitNo" + i;

                Control[] foundControls = this.Controls.Find(controlName, true);

                if ( foundControls.Length > 0 && foundControls[0] is Button)
                {
                    Button existingControl = (Button)foundControls[0];
                    existingControl.Click += Sit_Click;
                }
            }
        }

      

        private void Sit_Click(object sender, EventArgs e)
        {
            Button clickedControl = sender as Button; // 버튼 객체로 이벤트발생한 변수 잡아서 clickedControl에 넣기

            if (clickedControl != null)
            {
                string sitNo = clickedControl.Name.Replace("SitNo",""); // 컨트롤의 이름에서 숫자만 남기기

                int index;
                if (int.TryParse(sitNo, out index)) 
                {
                    SelectedSitNoIndex = index-1;
                    // 팦업 폼의 배열에 쓸 인덱스.
                }

              
            }

            PCSitStatusForm pcSitStatusForm = new PCSitStatusForm(this);
            pcSitStatusForm.ShowDialog();
            
         
        }

        private void SitManagementForm_Load(object sender, EventArgs e)
        {
            InitializeSits();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SitColorized();
        }

        private void SitManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
