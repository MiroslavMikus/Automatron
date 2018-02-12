using Automatron.Interfaces.Workflow;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Automatron.Triggers.Test.Fakes
{
    public class FakeSettings : IWorkflowElementSettings
    {
        public IValidator ValidationRules => null;

        public string InstanceName { get; set; }
        public string InstanceDescription { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(InstanceName), InstanceName);
            info.AddValue(nameof(InstanceDescription), InstanceDescription);
        }
    }
}
