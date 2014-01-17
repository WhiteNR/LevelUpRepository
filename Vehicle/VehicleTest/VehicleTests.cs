using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using NUnit.Util;
using Vehicle;

namespace VehicleTest
{
    [TestFixture]
    public class ExampleTestOfNUnit
    {
        [Test]
        public void IncreaseSpeedTest()
        {
            Avto avto = new Avto();
            int currentSpeed = avto.CurrentSpeed;
            avto.IncreaseSpeed();
            avto.CurrentSpeed.Should().BeGreaterThan(currentSpeed);
        }

        [Test]
        public void DecreaseSpeedTest()
        {
            Avto avto = new Avto();
            avto.IncreaseSpeed();
            int currentSpeed = avto.CurrentSpeed;
            avto.DecreaseSpeed();
            avto.CurrentSpeed.Should().BeLessThan(currentSpeed);
        }

        [Test]
        public void OverheatTest()
        {
            Avto avto = new Avto(1000,200,120,100);
            for (int i = 0; i < 9; i++)
            {
                try
                {
                    avto.IncreaseSpeed();
                }
                catch (Exception)
                {
                }  
            }
            avto.Engine.IsBroken.Should().Be(true);
        }
    }
}
