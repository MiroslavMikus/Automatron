namespace Automatron.Interfaces.Workflow.Nodes
{
    public interface IOutput<TSettings> : IHasLeftPoint<TSettings> where TSettings : IWorkflowElementSettings
    {

    }
}
