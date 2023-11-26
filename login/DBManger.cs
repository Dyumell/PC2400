using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{

    public class DBManager2
    {
        string accessedSitID;
        DataSet dS; // 복사된 데이터를 저장하는 변수
        OracleCommandBuilder myCommandBuilder; // 명령문을 자동으로 짜누는 도우미 변수
        OracleDataAdapter dBAdapter; // DS에 Fill 해줄 어뎁터 변수
        DataTable userTable; // DS를 테이블형태로 옮겨 저장할 변수
        DataRow[] resultRows; // 특정 열을 저장할 변수
        string connectionString;// DB에 연결할 문자열
        string commandString; // 명령문 

        OracleConnection connection; // 트랜잭션때문에 추가한 객체1
        OracleTransaction transaction; // 수정/삽입/삭제 커밋을 위한 트랜잭션
        OracleCommand command;

        public OracleCommand Command { get { return command; } set { command = value; } }
        public OracleConnection Connection { get { return connection; } set { connection = value; } }

        public OracleTransaction Transaction { get { return transaction; } set { transaction = value; } }
        public DataRow[] ResultRows { get { return resultRows; } set { resultRows = value; } }
        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }

        public DataSet DS { get { return dS; } set { dS = value; } }

        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }

        public DataTable UserTable { get { return userTable; } set { userTable = value; } }

        public string CommandString { get { return commandString; } set { commandString = value; } }

        public string ConnectionString { get { return connectionString; } }

        public string AcessedSitID { get { return accessedSitID; } set { accessedSitID = value; } }
        public DBManager2(string commandString)
        {
            try
            {
                this.connectionString = "User Id=dyumell; Password=1755; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void NonConnectType(string commandString)
        {
            this.commandString = commandString;

            DBAdapter = new OracleDataAdapter(CommandString, ConnectionString);
            MyCommandBuilder = new OracleCommandBuilder(DBAdapter);

            DS = new DataSet();

        }

        public void ConnectType(string commandString)
        {
            this.commandString = commandString;

            Connection = new OracleConnection(connectionString);
            Command = new OracleCommand();
            Command.Connection = Connection;
            Command.CommandText = commandString;

            Connection.Open();
           
        }

        public void TransactionOpen() // 비연결형에서 데이터 수정시 사용. 이거 안쓰면 커밋하기 위한 트랜젝션 부분에서 개체참조오류발생하더라
        {
            try
            {
                Connection = new OracleConnection(ConnectionString);
                Connection.Open();
                transaction = Connection.BeginTransaction();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }



    }
}