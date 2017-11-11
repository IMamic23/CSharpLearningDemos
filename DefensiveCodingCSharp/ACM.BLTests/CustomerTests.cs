using System;
using ACM.BL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalSteps_TestValid_ReturnsPercentage()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalSteps_TestValidAndSame_ReturnsPercentage()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalSteps_TestValidActualZero_ReturnsPercentage()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Actual steps must be greater then 0")]
        public void CalculatePercentOfGoalSteps_TestInvalidActualNegative_ReturnsException()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "-50";

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert - Expects exception
        }

        [TestMethod]
        public void CalculatePercentOfGoalSteps_TestInvalidGoalNegative_ReturnsException()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "-500";
            string actualSteps = "500";

            // Act and Assert - Expects exception
            Assert.ThrowsException<ArgumentException>(
                () => customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps), "Goal must be greater then 0");
        }

        [TestMethod]
        public void CalculatePercentOfGoalSteps_TestInvalidGoalText_ReturnsException()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "text";
            string actualSteps = "500";

            // Act and Assert - Expects exception
            Assert.ThrowsException<ArgumentException>(
                () => customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps), "Goal must be numeric");
        }

        [TestMethod]
        public void CalculatePercentOfGoalSteps_TestInvalidActualText_ReturnsException()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "500";
            string actualSteps = "text";

            // Act and Assert - Expects exception
            Assert.ThrowsException<ArgumentException>(
                () => customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps), "Actual steps must be numeric");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalSteps_InvalidGoalIsNull_ReturnsException()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert - expecting exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalSteps_InvalidGoalIsWhitespace_ReturnsException()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = " ";
            string actualSteps = "2000";

            // Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception e)
            {
                // Assert - expecting exception
                Assert.AreEqual("Goal must be entered", e.Message);
                throw;
            }
        }

        [TestMethod()]
        public void CalculatePercentOfGoalStepsTest()
        {
            //Assert.Fail();
        }
    }
}
