using System;
using Automatron.Interfaces.Workflow;
using Automatron.Interfaces.Workflow.Nodes;
using Automatron.Tirggers.Loop;
using Automatron.Triggers.Test.Fakes;
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
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CastSettingsTest_Fail()
        {
            // Arrange
            LoopTrigger trigger = new LoopTrigger();

            IWorkflowElementSettings settings = new FakeSettings();

            // Act
            trigger.Setting = settings;
        }
    }
}
