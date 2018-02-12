using Automatron.Interfaces.Workflow;
using FluentValidation;
using System.Runtime.Serialization;

namespace Automatron.Tirggers.Loop
{
    public class LoopTriggerSettings : IWorkflowElementSettings
    {
        public LoopTriggerSettings()
        {
            ValidationRules = LoopTriggerSettingsValidation.Singleton.Value;
        }

        #region IWorkflowElementSettings
        public IValidator ValidationRules { get; private set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(LoopCount), LoopCount);
            info.AddValue(nameof(LoopInterval), LoopInterval);
            info.AddValue(nameof(InstanceName), InstanceName);
            info.AddValue(nameof(InstanceDescription), InstanceDescription);
        }

        public string InstanceName { get; set; }

        public string InstanceDescription { get; set; }
        #endregion

        public int LoopCount { get; set; }

        /// <summary>
        /// Interval in seconds
        /// </summary>
        public int LoopInterval { get; set; }
    }
}
