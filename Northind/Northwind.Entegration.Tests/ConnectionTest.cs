using System.Linq;
using FluentAssertions;
using Northwind.DataSource;
using NUnit.Framework;

namespace Northwind.Entegration.Tests
{
    [TestFixture]
    public class ConnectionTest
    {
        [Test]
        public void TestDefaultConnection()
        {
            var provider = new DataProvider();
            provider.DataContext.Customers.Count().Should().BeGreaterThan(0);
        }
    }
}
