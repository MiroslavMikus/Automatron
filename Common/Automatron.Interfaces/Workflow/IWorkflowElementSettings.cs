using FluentValidation;
using System.Runtime.Serialization;

namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// Imlementation of this interface should contain all necesarry setting to run WorkflowElement.
    /// All properties will be read and written by reflection.
    /// Implementation must have empty constructor!
    /// </summary>
    public interface IWorkflowElementSettings : ISerializable
    {
        IValidator ValidationRules { get; }

        /// <summary>
        /// User should be able to give custom names to all workflow elements instances
        /// </summary>
        string InstanceName { get; set; }

        /// <summary>
        /// User should be able to describe every workflow element instance
        /// </summary>
        string InstanceDescription { get; set; }
    }
}