using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTester
{
    public class Simulator
    {
        public event EventHandler<SimulatorApplicationMessageEventArgs> SimulatorMessage;
        public event EventHandler<SimulatorSessionEventArgs> SimulatorSessionMessage;
        public Simulator() { }
        public void Logon() { }
        public void Logout() { }
        public void SendNewOrderSingle() { }
        public void SendCancelReplaceRequest() { }
        public void SendCancelRequest() { }
    }
    public class SimulatorApplicationMessageEventArgs : EventArgs
    {
        public string Message { get; set; }
        public SimulatorApplicationMessageEventArgs(string message) { this.Message = message; }
    }
    public class SimulatorSessionEventArgs : EventArgs
    {
        public ConnectionStatus ConnectionStatus { get; set; }
        public SimulatorSessionEventArgs(ConnectionStatus connectionStatus)
        {
            ConnectionStatus = connectionStatus;
        }
    }
    public enum ConnectionStatus
    {
        Disconnected,
        Connecting,
        Connected
    }
}
