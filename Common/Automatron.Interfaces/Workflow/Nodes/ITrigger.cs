namespace Automatron.Interfaces.Workflow.Nodes
{
    public interface ITrigger<TSettings> : IHasRightPoint<TSettings> where TSettings : IWorkflowElementSettings
    {
        /// <summary>
        /// Starts lisening for events / user interactions..
        /// This method have to change the <see cref="IsLisening"/>
        /// </summary>
        void StartLisen();

        /// <summary>
        /// Stops lisening
        /// This method have to change the <see cref="IsLisening"/>
        /// </summary>
        void StopLisen();

        /// <summary>
        /// Indicates the current state of the current <see cref="ITrigger"/>
        /// </summary>
        bool IsLisening { get; }
    }
}
