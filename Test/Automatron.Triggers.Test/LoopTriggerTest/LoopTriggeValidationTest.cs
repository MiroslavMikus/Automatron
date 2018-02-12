using Automatron.Tirggers.Loop;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatron.Triggers.Test.LoopTriggerTest
{

    [TestClass]
    public class LoopTriggeValidationTest
    {
        [DataTestMethod]
        [DataRow(1, 19)][DataRow(5, 5)][DataRow(5, 7)]
        [DataRow(7, 8)][DataRow(13, 3)][DataRow(7, 16)]
        [DataRow(4, 14)]
        public void LoopCountTest(int loopCount, int loopInterval)
        {
            // Arrange
            var settings = new LoopTriggerSettings { LoopCount = loopCount, LoopInterval = loopInterval };

            // Act
            var result = settings.ValidationRules.Validate(settings);

            // Assert
            Assert.IsFalse(result.Errors.Any());
        }

        [DataTestMethod]
        [DataRow(1, 29)]
        [DataRow(54, 5)]
        [DataRow(4, 24)]
        public void LoopCountTest_fails(int loopCount, int loopInterval)
        {
            // Arrange
            var settings = new LoopTriggerSettings { LoopCount = loopCount, LoopInterval = loopInterval };

            // Act
            var result = settings.ValidationRules.Validate(settings);

            // Assert
            Assert.IsTrue(result.Errors.Any());
        }
    }
}
