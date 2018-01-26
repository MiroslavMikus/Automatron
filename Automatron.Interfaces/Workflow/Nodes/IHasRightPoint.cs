using System.Collections.Generic;

namespace Automatron.Interfaces.Workflow.Nodes
{
    public interface IHasRightPoint
    {
        IEnumerable<IHasLeftPoint> RightPoints { get; set; }
    }
}
