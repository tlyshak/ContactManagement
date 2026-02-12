using System.Data.SQLite;
using System.Data;
using ContactManagement.Application.Interfaces.DataAccess;

namespace ContactManagement.Infrastructure.DataAccess
{
    public class SqliteConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;
        public string DataSource { get; }

        public SqliteConnectionFactory(string databasePath)
        {
            DataSource = databasePath;

            var builder = new SQLiteConnectionStringBuilder
            {
                DataSource = databasePath,
                Version = 3,
                JournalMode = SQLiteJournalModeEnum.Wal
            };

            _connectionString = builder.ToString();
        }

        public IDbConnection Create()
        {
            return new SQLiteConnection(_connectionString);
        }
    }
}
