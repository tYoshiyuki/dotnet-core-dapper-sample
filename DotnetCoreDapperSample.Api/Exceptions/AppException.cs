using System;
using System.Globalization;

namespace DotnetCoreDapperSample.Api.Exceptions
{
    /// <summary>
    /// アプリケーション固有の例外実装例です。
    /// </summary>
    public class AppException : Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
    }
}
