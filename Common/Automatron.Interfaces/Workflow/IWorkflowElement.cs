namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// This is base interface for every element in workflow
    /// </summary>
    public interface IWorkflowElement
    {
        string Name { get; set; }
        IWorkflowElementSetting Setting { get; set; }
    }
}