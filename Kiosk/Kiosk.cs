using login;
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

namespace Kiosk
{
    public partial class Kiosk : Form
    {
        int totalmoneyint;
        int totaltimeint;
        SearchID searchID;
        public Kiosk()
        {
            InitializeComponent();
        }

        private void Kiosk_Load(object sender, EventArgs e)
        {
            roundButton1.Text = "1시간\n1000원";
            roundButton2.Text = "2시간\n2000원";
            roundButton3.Text = "3시간\n3000원";
            roundButton4.Text = "5시간\n5000원";
            roundButton5.Text = "12시간\n10000원";
            roundButton6.Text = "25시간\n20000원";
            roundButton7.Text = "38시간\n30000원";
            roundButton8.Text = "60시간\n50000원";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchID = new SearchID(this); 
            searchID.ShowDialog();
        }
        public void idlabalChange(string newid)
        {
            idnow.Text = newid;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            totalmoneyint += 1000;
            totaltimeint += 1;
            pulstime();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            totalmoneyint += 2000;
            totaltimeint += 2;
            pulstime();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            totalmoneyint += 3000;
            totaltimeint += 3;
            pulstime();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            totalmoneyint += 5000;
            totaltimeint += 5;
            pulstime();
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            totalmoneyint += 10000;
            totaltimeint += 12;
            pulstime();
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            totalmoneyint += 20000;
            totaltimeint += 25;
            pulstime();
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            totalmoneyint += 30000;
            totaltimeint += 38;
            pulstime();
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            totalmoneyint += 50000;
            totaltimeint += 60;
            pulstime();
        }
        public void pulstime() {


            totaltime.Text = totaltimeint.ToString()+"시간";   
            totalmoney.Text = totalmoneyint.ToString()+"원";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = idnow.Text;
            if(id == "미선택")
            {
                MessageBox.Show("id를 먼저 선택해주세요");
                return;
            }
            
            DialogResult dialogResult;
            DialogResult dialogResult2;
            dialogResult = MessageBox.Show("총 " + totaltime.Text + "\n총 "+totalmoneyint.ToString()+"원 맞으실까요?","결제확인",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                //결제 화면 과정 뛰우기 일단지금은 메세지 박스로 구현해둘께요
                dialogResult2 = MessageBox.Show("결제완료?", "임시화면", MessageBoxButtons.YesNo);
                if(dialogResult2 == DialogResult.Yes)
                {
                    int totaltimemin = totaltimeint * 60;
                    
                    String updatecommandString = "Update USER_ACCOUNT_LOGIN SET REMAINED_TIME = REMAINED_TIME + "+totaltimemin+" WHERE USER_ID = '"+id+"'";
                    
                    try
                    {
                        
                        Updatequery updatequery= new Updatequery(updatecommandString, id, totaltimeint);
                        




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("결제실패!");
                }
            }
        }
        public void closeSearch()
        {
            searchID.Close();
        }
    }
}
