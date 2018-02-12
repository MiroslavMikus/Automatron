using FluentValidation;
using System.Runtime.Serialization;

namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// Imlementation of this interface should contain all necesarry setting to run WorkflowElement.
    /// All properties will be read and written by reflection.
    /// Implementation must have empty constructor!
    /// </summary>
    public interface IWorkflowElementSetting : ISerializable
    {
        IValidator ValidationRules { get; }
    }
}