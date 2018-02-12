using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automatron.Interfaces.Workflow;
using Automatron.Interfaces.Workflow.Nodes;

namespace Automatron.Interfaces.WorkUnit
{
    /// <summary>
    /// This object holds reference to one <see cref="ITrigger"/>, <see cref="IExecute"/> and <see cref="IOutput"/>
    /// and they concrete types and settings as well.
    /// </summary>
    public interface IWorkUnit
    {
        /// <summary>
        /// Test method will bypass the <see cref="Trigger"/> and run execute directly
        /// </summary>
        void Test();

        Type TriggerType { get; set; }
        ITrigger<IWorkflowElementSettings> Trigger { get; set; }

        Type ExecuteType { get; set; }
        IExecute<IWorkflowElementSettings> Execute { get; set; }

        Type OutputType { get; set; }
        IOutput<IWorkflowElementSettings> Output { get; set; }
    }
}
