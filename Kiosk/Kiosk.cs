using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Kiosk : Form
    {
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
            SearchID searchID = new SearchID(); 
            searchID.ShowDialog();
        }
        public void idlabalChange(string newid)
        {
            idnow.Text = newid;
        }
    }
}
