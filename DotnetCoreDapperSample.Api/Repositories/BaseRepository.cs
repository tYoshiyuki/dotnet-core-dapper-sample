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
    }
}
