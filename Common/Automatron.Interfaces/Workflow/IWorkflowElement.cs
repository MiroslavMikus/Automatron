namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// This is base interface for every element in workflow
    /// </summary>
    public interface IWorkflowElement
    {
        /// <summary>
        /// Name of Workflow element
        /// </summary>
        /// <example>
        /// LoopTrigger -> Loop
        /// </example>
        string ElementName { get;}

        /// <summary>
        /// Description for workflow element.
        /// User should be able to see this description while selecting/creating a new element.
        /// </summary>
        /// <example>
        /// LoopTrigger:
        /// Executes script by given interval
        /// </example>
        string ElementDescription { get; }

        IWorkflowElementSettings Setting { get; set; }
    }
}