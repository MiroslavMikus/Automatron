using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatron.Interfaces.Workflow.Nodes
{
    /// <summary>
    /// All workflow elements which contains Left connector / Input
    /// </summary>
    public interface IHasLeftPoint : IWorkflowElement
    {
        string Execute(IWorkflowElementSettings a_settings);
    }
}
