using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatron.Interfaces.Workflow.Nodes
{
    public interface IHasLeftPoint
    {
        string Execute(IWorkflowElementSetting a_settings);
    }
}
