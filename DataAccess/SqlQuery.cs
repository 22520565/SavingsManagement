namespace DataAccess
{
    using Entity;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;

    public static class SqlQuery
    {
        private static readonly string ConnectionString = "Data Source={0};Initial Catalog={1};Integrated Security=SSPI;";
        private static readonly object LockConnectionObj = new object();
        private static readonly object LockExecutionObj = new object();
        private static readonly SqlConnection SqlConnection = new SqlConnection(
                string.Format(CultureInfo.InvariantCulture, ConnectionString, "DESKTOP-O6AO007\\SQLEXPRESS", "SavingsManagement"));

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

        public static string? GetValue(string sqlCommandString)//
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
                sqlDataReader.Close();
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

        //
        public static List<Account> Accounts(string sqlCommandString) // login, signup, forgot password, account permission
        {
            List<Account> accounts = new List<Account>();
            OpenConnection();
            using (SqlCommand cmd = new SqlCommand(sqlCommandString, SqlConnection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    accounts.Add(new Account(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetInt32(5),
                                             reader.GetString(6), reader.GetBoolean(7), reader.GetString(8), reader.GetDateTime(9), reader.GetString(10), reader.GetString(11), reader.GetDecimal(12)));
                }
            }
            CloseConnection();
            return accounts;
        }
    }
}
