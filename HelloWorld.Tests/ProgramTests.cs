using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using HelloWorld;

namespace HelloWorld.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GivenTwoIntegers_WhenAddIsCall_ThenIntegerIsReturned()
        {
            // var mockArithmetic = new Mock<Arithmetic>();
            var target = new Arithmetic();

            // Act
            var actual = target.Add(1, 2);

            // Assert
            Assert.AreEqual(actual, 3);
        }

        [TestMethod]
        public void GivenTwoIntegers_WhenMultiplyIsCall_ThenIntegerIsReturned()
        {
            // var mockArithmetic = new Mock<Arithmetic>();
            var target = new Arithmetic();

            // Act
            var actual = target.Multiply(1, 2);

            // Assert
            Assert.AreEqual(actual, 2);
        }

        [TestMethod]
        public void GivenTwoIntegers_WhenSubtractIsCall_ThenIntegerIsReturned()
        {
            // var mockArithmetic = new Mock<Arithmetic>();
            var target = new Arithmetic();

            // Act
            var actual = target.Subtract(2, 1);

            // Assert
            Assert.AreEqual(actual, 1);
        }
    }
}
