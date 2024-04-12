namespace DataAccess
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;

    public static class SqlQuery
    {
        private static readonly string ConnectionString = "Data Source={0};Initial Catalog={1};Integrated Security=SSPI;";
        private static readonly object LockConnectionObj = new object();
        private static readonly object LockExecutionObj = new object();
        private static readonly SqlConnection SqlConnection = new SqlConnection(
                string.Format(CultureInfo.InvariantCulture, ConnectionString, "DESKTOP-COFIP2B", "SavingsManagement"));

        public static void ExecuteSqlCommand(string sqlCommandString)
        {
            lock (LockExecutionObj)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlCommandString, SqlConnection);
                    OpenConnection();
                    sqlCommand.ExecuteNonQuery();
                    CloseConnection();
                    sqlCommand.Dispose();
                }
                catch
                {
                    // ignore
                }
            }
        }

        public static DataTable GetDataTable(string sqlCommandString)
        {
            DataTable dataTable = new DataTable();
            lock (LockExecutionObj)
            {
                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandString, SqlConnection);
                    OpenConnection();
                    sqlDataAdapter.Fill(dataTable);
                    CloseConnection();
                    sqlDataAdapter.Dispose();
                }
                catch
                {
                    // ignore
                }
            }
            return dataTable;
        }

        public static string? GetValue(string sqlCommandString)
        {
            lock (LockExecutionObj)
            {
                string? valueToGet = null;
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlCommandString, SqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    valueToGet = sqlDataReader.GetString(0);
                }
                CloseConnection();
                return valueToGet;
            }
        }

        private static void OpenConnection()
        {
            lock (LockConnectionObj)
            {
                if (SqlConnection.State != ConnectionState.Open)
                {
                    SqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("set dateformat dmy", SqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
            }
        }

        private static void CloseConnection()
        {
            lock (LockConnectionObj)
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
        }
    }
}
