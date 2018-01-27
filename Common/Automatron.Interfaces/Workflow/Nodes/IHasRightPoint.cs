using Automatron.Interfaces.Events;

namespace Automatron.Interfaces.Workflow.Nodes
{
    /// <summary>
    /// All workflow elements which contains Right connector / Output
    /// </summary>
    public interface IHasRightPoint: IWorkflowElement
    {
        /// <summary>
        /// will be invoked when <see cref="ITrigger"/> conditions are met
        /// or <see cref="IExecute"/> finish execution
        /// </summary>
        event InvokeNextEventHandler InvokeNext;
    }
}
