using System.Configuration;
using System.Data.SqlClient;

namespace BookPhoneApp.Core.Data
{
    public class BookPhoneDB
    {
        SqlConnection myConn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);

        public void OpenConnection()
        {
            if (myConn.State == System.Data.ConnectionState.Closed)
                myConn.Open();
        }

        public void CloseConnection()
        {
            if (myConn.State == System.Data.ConnectionState.Open)
                myConn.Close();
        }

        public SqlConnection GetConnection()
        {
            return myConn;
        }
    }
}
