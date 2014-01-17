using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Northwind.Entities;
using NUnit.Framework;

namespace Northwind.Entegration.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void GetAllCustomerTest()
        {
            var customerDS = new CustomerOrders();
            var customersCount = customerDS.GetCustomersCount;
            customerDS.GetAllCustomers.Count().Should().Be(customersCount);
        }
    }
}
