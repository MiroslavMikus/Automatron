using Automatron.Interfaces.Events;
using Automatron.Interfaces.Workflow;
using Automatron.Interfaces.Workflow.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;


namespace Automatron.Tirggers.Loop
{
    public class LoopTrigger : ITrigger<LoopTriggerSettings>
    {
        #region ITrigger properties

        public bool IsLisening { get; private set; }

        public string ElementName => "Loop";

        public string ElementDescription => "Runs script by given interval and for given iterations";

        public LoopTriggerSettings Setting { get; set; }

        public event InvokeNextEventHandler InvokeNext;
        #endregion

        private Timer _executionTimer;

        public void StartLisen()
        {
            if (IsLisening) return;

            int tempLoopCount = Setting.LoopCount;

            _executionTimer = new Timer(Setting.LoopInterval * 1000);

            _executionTimer.Elapsed += (a, b) =>
            {
                if (Interlocked.Decrement(ref tempLoopCount) <= 0)
                {
                    StopLisen();
                }
                else
                {
                    var args = new InvokeNextEventArgs("");

                    if (InvokeNext != null)
                        InvokeNext.Invoke(args);
                }
            };

            _executionTimer.Start();

            IsLisening = true;
        }

        public void StopLisen()
        {
            if (!IsLisening) return;

            _executionTimer.Stop();

            _executionTimer.Dispose();

            IsLisening = false;
        }
    }
}
