using login;
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
    
    public partial class SearchID : Form
    {
        public DBManager DBManager;
        private Kiosk kiosk;
        
        public SearchID()
        {
            InitializeComponent();
        }

        private void SearchUserID_Click(object sender, EventArgs e)
        {
            string id = txtSearchUserID.Text;
            string commandString = "select * from user_account_login where user_account_login.user_id ='" + id + "'";
            try
            {
                DBManager = new DBManager(commandString);
                DBManager.DBAdapter.Fill(DBManager.DS, "id");
                DBManager.UserTable = DBManager.DS.Tables["id"];
                if (DBManager.DS.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show(id + "님 확인되었습니다");
                }else
                {
                    MessageBox.Show("id를 다시한번 확인해주세요");
                }
                
                
               /* kiosk.idlabalChange(id);*/

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                /*DialogResult result = MessageBox.Show("해당되는 id가 없습니다\n다시한번 확인해주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Question);*/
            }
            
        }

        private void SearchID_Load(object sender, EventArgs e)
        {
            /*InitializeComponent();
            this.kiosk = kiosk;*/
        }
    }
}
