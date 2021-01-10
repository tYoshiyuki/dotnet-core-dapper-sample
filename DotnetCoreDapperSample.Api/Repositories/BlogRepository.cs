using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DotnetCoreDapperSample.Api.Models;

namespace DotnetCoreDapperSample.Api.Repositories
{
    public class BlogRepository : BaseRepository
    {
        public BlogRepository(IDbConnection dbConnection) : base(dbConnection) { }

        public Blog Get(int id)
        {
            return DbConnection.Query<Blog>("SELECT * FROM BLOG WHERE ID = :Id", new { Id = id }).FirstOrDefault();
        }

        public IEnumerable<Blog> GetList()
        {
            return DbConnection.Query<Blog>("SELECT * FROM BLOG");
        }

        public int Create(Blog blog)
        {
            return DbConnection.Execute("INSERT INTO BLOG (ID, NAME) VALUES (:Id, :Name)", blog);
        }
    }
}
