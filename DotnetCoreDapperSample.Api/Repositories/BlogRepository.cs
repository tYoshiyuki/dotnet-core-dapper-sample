using System.Collections.Generic;
using System.Data;
using Dapper;
using DotnetCoreDapperSample.Api.Models;

namespace DotnetCoreDapperSample.Api.Repositories
{
    public class BlogRepository : BaseRepository
    {
        public BlogRepository(IDbConnection dbConnection) : base(dbConnection) { }

        public IEnumerable<Blog> GetList()
        {
            return DbConnection.Query<Blog>("SELECT * FROM BLOG");
        }
    }
}
