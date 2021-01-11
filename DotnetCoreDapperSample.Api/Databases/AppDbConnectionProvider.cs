using System;
using System.Data;

namespace DotnetCoreDapperSample.Api.Databases
{
    /// <summary>
    /// IDbConnection を提供するためのクラスです。
    /// (※) 複数のDbConnectionをDIコンテナで管理することを想定したクラスになります。
    /// </summary>
    public class AppDbConnectionProvider : IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public AppDbConnectionProvider(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IDbConnection GetDbConnection() => _dbConnection;

        public void Dispose()
        {
            _dbConnection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
