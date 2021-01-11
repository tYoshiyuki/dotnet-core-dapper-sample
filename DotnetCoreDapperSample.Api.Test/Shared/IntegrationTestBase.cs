using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace DotnetCoreDapperSample.Api.Test.Shared
{
    public abstract class IntegrationTestBase
    {
        protected static HttpClient client;

        [OneTimeSetUp]

        public virtual void OneTimeSetUp()
        {
            var factory = new WebApplicationFactory<Startup>();
            client = factory.CreateClient();
        }
    }
}
