using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace Kiosk
{

    internal class Updatequery
    {
        string connectionString = "User Id=dyumell; Password = 1755; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
        public Updatequery(String uQuery,String id, int time) {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(uQuery,connection))
                    {



                        
                        int effected = command.ExecuteNonQuery();
                        if (effected > 0)
                        {

                            MessageBox.Show(id + "님\n" + time.ToString() + "시간 충전되었습니다");
                            
                            connection.Close();

                            
                        }
                        else
                        {
                            MessageBox.Show("충전실패! 결제된경우 카운터로 문의 주세요");
                            connection.Close();
                        }
                        //connection.Close();
                    }
                }
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
