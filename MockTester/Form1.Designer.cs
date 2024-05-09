namespace MockTester
{
    partial class RoboKenzo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ipText = new TextBox();
            portText = new TextBox();
            rawDataText = new TextBox();
            ipLabel = new Label();
            portLabel = new Label();
            rawDataLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            senderText = new TextBox();
            label2 = new Label();
            targetText = new TextBox();
            label4 = new Label();
            statusLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            connectButton = new Button();
            disconnectButton = new Button();
            comboBoxSessions = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.625F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(comboBoxSessions, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(526, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.45863F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.20804F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.Size = new Size(271, 444);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1698112F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.8301849F));
            tableLayoutPanel4.Controls.Add(ipText, 1, 0);
            tableLayoutPanel4.Controls.Add(portText, 1, 1);
            tableLayoutPanel4.Controls.Add(rawDataText, 1, 2);
            tableLayoutPanel4.Controls.Add(ipLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(portLabel, 0, 1);
            tableLayoutPanel4.Controls.Add(rawDataLabel, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.Size = new Size(265, 133);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // ipText
            // 
            ipText.Location = new Point(75, 3);
            ipText.Name = "ipText";
            ipText.Size = new Size(100, 23);
            ipText.TabIndex = 0;
            // 
            // portText
            // 
            portText.Location = new Point(75, 47);
            portText.Name = "portText";
            portText.Size = new Size(100, 23);
            portText.TabIndex = 1;
            // 
            // rawDataText
            // 
            rawDataText.Location = new Point(75, 91);
            rawDataText.Name = "rawDataText";
            rawDataText.Size = new Size(100, 23);
            rawDataText.TabIndex = 2;
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new Point(3, 0);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(20, 15);
            ipLabel.TabIndex = 3;
            ipLabel.Text = "IP:";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(3, 44);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(32, 15);
            portLabel.TabIndex = 4;
            portLabel.Text = "Port:";
            // 
            // rawDataLabel
            // 
            rawDataLabel.AutoSize = true;
            rawDataLabel.Location = new Point(3, 88);
            rawDataLabel.Name = "rawDataLabel";
            rawDataLabel.Size = new Size(59, 15);
            rawDataLabel.TabIndex = 5;
            rawDataLabel.Text = "Raw Data:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(senderText);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(targetText);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(statusLabel);
            flowLayoutPanel1.Location = new Point(3, 142);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(223, 87);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "SenderCompId";
            // 
            // senderText
            // 
            senderText.Location = new Point(95, 3);
            senderText.Name = "senderText";
            senderText.Size = new Size(100, 23);
            senderText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "TargetCompId";
            // 
            // targetText
            // 
            targetText.Location = new Point(91, 32);
            targetText.Name = "targetText";
            targetText.Size = new Size(100, 23);
            targetText.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 58);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Status: ";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(54, 58);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(124, 15);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "CONNECTION STATUS";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(connectButton, 0, 0);
            tableLayoutPanel3.Controls.Add(disconnectButton, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 235);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(200, 71);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(3, 3);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 23);
            connectButton.TabIndex = 0;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // disconnectButton
            // 
            disconnectButton.Location = new Point(103, 3);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new Size(75, 23);
            disconnectButton.TabIndex = 1;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += disconnectButton_Click;
            // 
            // comboBoxSessions
            // 
            comboBoxSessions.DisplayMember = "Name";
            comboBoxSessions.FormattingEnabled = true;
            comboBoxSessions.Location = new Point(3, 419);
            comboBoxSessions.Name = "comboBoxSessions";
            comboBoxSessions.Size = new Size(121, 23);
            comboBoxSessions.TabIndex = 3;
            comboBoxSessions.SelectionChangeCommitted += comboBoxSessions_SelectionChangeCommitted;
            // 
            // RoboKenzo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "RoboKenzo";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox senderText;
        private Label label2;
        private TextBox targetText;
        private Label label4;
        private Label statusLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button connectButton;
        private Button disconnectButton;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox ipText;
        private TextBox portText;
        private TextBox rawDataText;
        private Label ipLabel;
        private Label portLabel;
        private Label rawDataLabel;
        private ComboBox comboBoxSessions;
    }
}
