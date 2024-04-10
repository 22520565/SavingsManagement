namespace DataAccess
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;

    public static class SqlAccess
    {
        private static readonly object LockConnectionObj = new object();
        private static readonly object LockExecutionObj = new object();
        private static SqlConnection? sqlConnection = null;

        public static void ExecuteSqlCommand(string sqlCommandString)
        {
            lock (LockExecutionObj)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection);
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

        public static DataTable? GetDataTable(string sqlCommandString)
        {
            lock (LockExecutionObj)
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandString, sqlConnection);
                    OpenConnection();
                    sqlDataAdapter.Fill(dataTable);
                    CloseConnection();
                    sqlDataAdapter.Dispose();
                    return dataTable;
                }
                catch
                {
                    // ignore
                }
                return null;
            }
        }

        public static string? GetValue(string sqlCommandString)
        {
            lock (LockExecutionObj)
            {
                string? valueToGet = null;
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(sqlCommandString, sqlConnection);
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
            const string connectingString = "Data Source={0};Initial Catalog={1};Integrated Security=SSPI;";
            sqlConnection ??= new SqlConnection(
                string.Format(CultureInfo.InvariantCulture, connectingString, "DESKTOP-COFIP2B", "SavingsManagement"));
            lock (LockConnectionObj)
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("set dateformat dmy", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }
            }
        }

        private static void CloseConnection()
        {
            lock (LockConnectionObj)
            {
                if ((sqlConnection != null) && (sqlConnection.State == ConnectionState.Open))
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
