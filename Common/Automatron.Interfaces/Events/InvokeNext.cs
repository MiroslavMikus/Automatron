using System;

namespace Automatron.Interfaces.Events
{
    public delegate void InvokeNextEventHandler(InvokeNextEventArgs e);

    public class InvokeNextEventArgs : EventArgs
    {
        public InvokeNextEventArgs(string a_output)
        {
            Output = a_output;
        }

        public string Output;
    }
}
