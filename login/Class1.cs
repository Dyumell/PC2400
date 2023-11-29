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

    public class DBManager
    {
        string accessedSitID;
        DataSet dS; // 복사된 데이터를 저장하는 변수
        OracleCommandBuilder myCommandBuilder; // 명령문을 자동으로 짜누는 도우미 변수
        OracleDataAdapter dBAdapter; // DS에 Fill 해줄 어뎁터 변수
        DataTable dTable; // DS를 테이블형태로 옮겨 저장할 변수
        DataRow[] resultRows; // 특정 열을 저장할 변수
        string connectionString;// DB에 연결할 문자열
        string commandString; // 명령문 

        OracleCommand myCommand; // parameter 사용을 위한 객체

        OracleConnection connection; // 트랜잭션때문에 추가한 객체1
        OracleTransaction transaction; // 수정/삽입/삭제 커밋을 위한 트랜잭션
        OracleDataReader dataReader;

        public OracleDataReader DataReader { get { return dataReader; } set { dataReader = value; } }
        public OracleCommand MyCommand { get { return myCommand; } set { myCommand = value; } }
        public OracleConnection Connection { get { return connection; } set { connection = value; } }

        public  OracleTransaction Transaction {  get {  return transaction; } set { transaction = value; } }    
        public DataRow[] ResultRows {  get { return resultRows; } set { resultRows = value; } }
        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }

        public DataSet DS { get { return dS; } set { dS = value; } }

        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }

        public DataTable DTable { get { return dTable; } set { dTable = value; } }

        public string CommandString { get { return commandString; } set { commandString = value; } }

        public string ConnectionString { get { return connectionString; } }

        public string AcessedSitID {  get { return accessedSitID; } set {  accessedSitID = value; } }

     
        public DBManager(string commandString)
        {
            try
            {
                this.connectionString = "User Id=dyumell; Password=1755; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));";
                this.commandString = commandString;

                DBAdapter = new OracleDataAdapter(CommandString, connectionString);

                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);


                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void LetsUseParameter()
        {
            Connection = new OracleConnection(ConnectionString);
        }

        public void TransactionOpen()
        {
            Connection = new OracleConnection(ConnectionString);
            Connection.Open();
            transaction = Connection.BeginTransaction();
        }

        
        
    }
}
