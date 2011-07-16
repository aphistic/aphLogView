using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace aphLogView.Shared.Data
{
    public class DataConnection : IDisposable
    {
        private string _host = "";
        private string _username = "";
        private string _password = "";
        private string _database = "";
        private string _table = "";

        private SqlConnection _conn = null;

        public string Host { get { return _host; } set { _host = value; } }
        public string Username { set { _username = value; } }
        public string Password { set { _password = value; } }
        public string Database { get { return _database; } set { _database = value; } }
        public string Table { get { return _table; } set { _table = value; } }

        public ConnectionState State
        {
            get { return _conn.State; }
        }

        private string GenerateConnectionString(string host, string database, string username, string password)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = host;
            if (!string.IsNullOrEmpty(database))
            {
                builder.InitialCatalog = database;
            }
            builder.UserID = username;
            builder.Password = password;

            builder.ConnectTimeout = 5;

            return builder.ToString();
        }

        public void Open()
        {
            _conn = new SqlConnection(GenerateConnectionString(_host, _database, _username, _password));
            _conn.Open();
        }

        public List<string> GetDatabases()
        {
            var databases = new List<string>();

            var dbs = _conn.GetSchema("Databases");
            foreach (DataRow db in dbs.Rows)
            {
                databases.Add((string) db["database_name"]);
            }
            databases.Sort();

            return databases;
        }
        public List<string> GetTables()
        {
            return GetTables(_database);
        }
        public List<string> GetTables(string database)
        {
            if (string.IsNullOrEmpty(database)) throw new ArgumentException("database");

            var tables = new List<string>();
            var sb = new StringBuilder();
            sb.AppendFormat("USE {0};", database);
            sb.Append("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.Tables ");
            sb.Append("WHERE TABLE_TYPE = 'BASE TABLE';");
            using (var comm = new SqlCommand(sb.ToString(), _conn))
            {
                using (var dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tables.Add(dr.GetString(dr.GetOrdinal("TABLE_NAME")));
                    }
                }
            }

            tables.Sort();
            return tables;
        }

        public IEnumerable<LogEntry> GetLatestEntries(int entryCount)
        {
            var entries = new List<LogEntry>();

            var query = new StringBuilder();
            query.AppendFormat("SELECT TOP {0} * FROM {1} ", entryCount, _table);
            query.Append("ORDER BY Date DESC");
            using (var comm = new SqlCommand(query.ToString(), _conn))
            {
                using (var da = new SqlDataAdapter(comm))
                {
                    using (var ds = new DataSet())
                    {
                        da.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            entries.AddRange(from row in ds.Tables[0].Rows.Cast<DataRow>()
                                             where row != null
                                             select GetEntry(row));
                        }
                    }
                }
            }

            return entries;
        }

        private static LogEntry GetEntry(DataRow row)
        {
            return new LogEntry
                       {
                           Date = (DateTime) row["Date"],
                           Thread = (string) row["Thread"],
                           Level = LogLevelHelper.GetLogLevel((string) row["Level"]),
                           Logger = (string) row["Logger"],
                           Message = (string) row["Message"],
                           Exception = (string) row["Exception"]
                       };
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State != ConnectionState.Closed)
                {
                    _conn.Close();
                }
                _conn.Dispose();
            }
        }
    }
}
