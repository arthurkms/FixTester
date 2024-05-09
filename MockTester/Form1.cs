using System.Runtime.CompilerServices;

namespace MockTester
{
    public partial class RoboKenzo : Form
    {
        public Simulator simulator {  get; set; }
        public RoboKenzo()
        {
            InitializeComponent();
            this.Icon = new Icon("letter-k-square.ico");
            this.comboBoxSessions.Items.AddRange(Examples.GetFixSessions());
            simulator.SimulatorMessage += handleSimulatorMessage;
            simulator.SimulatorSessionMessage += handleSimulatorSessionMessage;
        }

        private void handleSimulatorSessionMessage(object? sender, SimulatorSessionEventArgs e)
        {
            if (e.ConnectionStatus == ConnectionStatus.Connected)
            {
                statusLabel.BackColor = Color.Green;
                statusLabel.ForeColor = Color.White;
            }
            else if(e.ConnectionStatus == ConnectionStatus.Disconnected)
            {
                statusLabel.BackColor = Color.Red;
                statusLabel.ForeColor = Color.White;
            }
            else
            {
                statusLabel.BackColor = Color.Yellow;
                statusLabel.ForeColor = Color.White;
            }

        }

        private void handleSimulatorMessage(object? sender, SimulatorApplicationMessageEventArgs e)
        {
            //Do something with the message
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //Try Connect
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            
            //Try Disconnect
        }

        private void comboBoxSessions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var session = (FixSessionConfig)((ComboBox)sender).SelectedItem;
            ipText.Text = session?.IP;
            portText.Text = session?.Port.ToString();
            rawDataText.Text = session?.RawData;
            senderText.Text = session?.SenderCompId;
            targetText.Text = session?.TargetCompId;
        }
    }
}
