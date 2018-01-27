namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// This is base interface for every element in workflow
    /// </summary>
    public interface IWorkflowElement
    {
        /// <summary>
        /// User should be able to give custom names to all workflow elements
        /// </summary>
        string Name { get; set; }
        IWorkflowElementSetting Setting { get; set; }
    }
}