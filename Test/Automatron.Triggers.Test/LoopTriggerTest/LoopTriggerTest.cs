using System;
using System.Collections.Generic;
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
            Assert.AreEqual(settings.LoopCount, trigger.Setting.LoopCount);
        }

        [TestMethod]
        public void CastLoopTriggerToBaseTest()
        {
            // Arrange
            LoopTriggerSettings settings = new LoopTriggerSettings { LoopCount = 10, LoopInterval = 16};

            // Act
            ITrigger<IWorkflowElementSettings> trigger = 
                new LoopTrigger() as ITrigger<IWorkflowElementSettings>;

            // Assert
            Assert.IsNotNull(trigger);
        }
    }
}
