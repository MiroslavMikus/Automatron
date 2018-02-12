using System;
using Automatron.Interfaces.Workflow;
using Automatron.Interfaces.Workflow.Nodes;
using Automatron.Tirggers.Loop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automatron.Triggers.Test.LoopTriggerTest
{
    [TestClass]
    public class LoopTriggerTest
    {
        [TestMethod]
        public void CastSettingsTest()
        {
            // Arrange
            LoopTriggerSettings settings = new LoopTriggerSettings { LoopCount = 10, LoopInterval = 16};

            LoopTrigger trigger = new LoopTrigger();
            
            // Act
            trigger.Setting = settings;

            // Assert

            Assert.AreEqual(settings.LoopCount, trigger.Setting);
        }
    }
}
