namespace Automatron.Interfaces.Workflow.Nodes
{
    public interface IExecute<TSettings> : IHasLeftPoint<TSettings>, IHasRightPoint<TSettings> where TSettings : IWorkflowElementSettings
    {

    }
}
