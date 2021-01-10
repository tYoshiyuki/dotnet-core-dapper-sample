using System.Data;

namespace DotnetCoreDapperSample.Api.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly IDbConnection DbConnection;

        protected BaseRepository(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }

        public IDbTransaction BeginTransaction()
        {
            if (DbConnection.State == ConnectionState.Closed) DbConnection.Open();
            return DbConnection.BeginTransaction(IsolationLevel.ReadCommitted);
        }
    }
}
