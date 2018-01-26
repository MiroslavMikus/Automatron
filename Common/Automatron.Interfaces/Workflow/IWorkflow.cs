using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatron.Interfaces.Workflow
{
    /// <summary>
    /// The Main Window Canvas
    /// </summary>
    public interface IWorkflow
    {
        string Name { get; set; }
        IEnumerable<IWorkflowElement> Elements { get; set; }
    }
}
