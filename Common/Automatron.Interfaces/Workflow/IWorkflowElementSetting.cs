using FluentValidation;

namespace Automatron.Interfaces.Workflow
{
    public interface IWorkflowElementSetting
    {
        IValidator ValidationRules { get; }
    }
}