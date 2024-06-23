using System.Data;
using System.Data.SqlClient;

namespace PC_SHOP
{
    public abstract class Connection
    {        
        private static SqlConnection _conn;
        private static SqlCommand _cmd;
        private static string _query, _path, _databaseName;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public static string environmentPath { get; private set; }
        public static string environmentDatabaseName { get; set; }
        public static DataTable currentTable = new DataTable();


        public static void SetEnvironmentData(string environmentPath, string environmentDatabaseName)
        {
            Connection.environmentPath = environmentPath;
            Connection.environmentDatabaseName = environmentDatabaseName;
        }

        public static void SetConnectionSettings(string _connectionPath, string _connectionDatabaseName)
        {
            Connection._path = (_connectionPath == "") ? @".\SQLEXPRESS" : _connectionPath;
            Connection._databaseName = (_connectionDatabaseName == "") ? "master" : _connectionDatabaseName;
        }

        public static void Open()
        {
            Connection._conn = new SqlConnection($"Data Source={Connection._path};Initial Catalog={Connection._databaseName};Integrated Security=True");
            switch (Connection._conn.State == ConnectionState.Closed)
            {
                case true:
                    Connection._conn.Open();
                    return;
                case false:
                    Connection.Reconnect();
                    return;
            }
        }
        public static void Open(string _connectionPath, string _connectionDatabaseName)
        {
            Connection._path = (_connectionPath == "") ? @".\SQLEXPRESS" : _connectionPath;
            Connection._databaseName = (_connectionDatabaseName == "") ? "master" : _connectionDatabaseName;
            Connection._conn = new SqlConnection($"Data Source={Connection._path};Initial Catalog={Connection._databaseName};Integrated Security=True");
            switch (Connection._conn.State == ConnectionState.Closed)
            {
                case true:
                    Connection._conn.Open();
                    return;
                case false:
                    Connection.Reconnect();
                    return;
            }
        }

        public static void Reconnect()
        {
            Connection.Close();
            Connection._conn = new SqlConnection($"Data Source={Connection._path};Initial Catalog={Connection._databaseName};Integrated Security=True");
            Connection._conn.Open();
        }

        public static void SetQuery(string _query)
        {
            Connection._query = _query;
        }

        public static int ExecuteQuery()
        {
            _cmd = new SqlCommand(_query, _conn);
            return _cmd.ExecuteNonQuery();
        }

        public static DataTable SelectDataFromTable(string _query)
        {
            Connection._query = _query;
            _cmd = new SqlCommand(_query, _conn);
            adapter.SelectCommand = _cmd;
            currentTable.Rows.Clear();
            currentTable.Columns.Clear();
            adapter.Fill(currentTable);
            return currentTable;
        }

        public static SqlCommand GetSqlCommand()
        {
            _cmd = new SqlCommand(_query, _conn);
            return _cmd;
        }

        public static string GetQueryForDatabaseCreate(string path, string databaseName)
        {
            return $"create database {databaseName} on primary " +
                $"(name = {databaseName}_Data, " +
                $"filename = '{path}\\{databaseName}_Data.mdf', " +
                $"size = 2MB, maxsize = 10MB, filegrowth = 10%) " +
                $"log on (name = {databaseName}_Log, " +
                $"filename = '{path}\\{databaseName}_Log.ldf', " +
                "size = 1MB, " +
                "maxsize = 5MB, " +
                "filegrowth = 10%)";
        }

        public static string GetQueryForDropDatabase(string databaseName)
        {
            return $"DROP DATABASE {databaseName};";
        }

        public static void Close()
        {
            switch (Connection._conn.State == ConnectionState.Open)
            {
                case true:
                    Connection._conn.Close();
                    return;
                case false: return;
            }
        }
    }
}
