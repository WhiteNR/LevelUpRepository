using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using NUnit.Util;

namespace VehicleTest
{
    [TestFixture]
    public class ExampleTestOfNUnit
    {
        [Test]
        public void TestMultiplication()
        {
            Assert.AreEqual(4, 1 * 2, "Умножение");
        }
    }
}
