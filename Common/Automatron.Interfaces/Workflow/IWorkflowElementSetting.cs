using FluentValidation;

namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// Imlementation of this interface should contain all necesarry setting to run WorkflowElement.
    /// All properties will be read and written by reflection.
    /// Implementation must have empty constructor!
    /// </summary>
    public interface IWorkflowElementSetting
    {
        IValidator ValidationRules { get; }
    }
}