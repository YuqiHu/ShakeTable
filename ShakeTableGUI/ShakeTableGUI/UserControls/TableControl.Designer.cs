namespace ShakeTableGUI.UserControls
{
    partial class TableControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.COM_PORT = new System.Windows.Forms.Label();
            this.ImportFile = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.FileProperties = new System.Windows.Forms.RichTextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Backtoorigin = new System.Windows.Forms.Button();
            this.Calibration = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.richTextBox_textReceiver = new System.Windows.Forms.RichTextBox();
            this.Arduino_Table_Control = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_comPort);
            this.panel1.Controls.Add(this.COM_PORT);
            this.panel1.Controls.Add(this.ImportFile);
            this.panel1.Controls.Add(this.ImportButton);
            this.panel1.Controls.Add(this.FileProperties);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Backtoorigin);
            this.panel1.Controls.Add(this.Calibration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 611);
            this.panel1.TabIndex = 1;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(102, 258);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(167, 24);
            this.comboBox_comPort.TabIndex = 31;
            // 
            // COM_PORT
            // 
            this.COM_PORT.AutoSize = true;
            this.COM_PORT.Location = new System.Drawing.Point(11, 263);
            this.COM_PORT.Name = "COM_PORT";
            this.COM_PORT.Size = new System.Drawing.Size(84, 16);
            this.COM_PORT.TabIndex = 30;
            this.COM_PORT.Text = "COM PORT: ";
            // 
            // ImportFile
            // 
            this.ImportFile.Location = new System.Drawing.Point(102, 308);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(167, 22);
            this.ImportFile.TabIndex = 29;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 306);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 30);
            this.ImportButton.TabIndex = 28;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // FileProperties
            // 
            this.FileProperties.Location = new System.Drawing.Point(0, 348);
            this.FileProperties.Name = "FileProperties";
            this.FileProperties.Size = new System.Drawing.Size(284, 263);
            this.FileProperties.TabIndex = 4;
            this.FileProperties.Text = " File: \n Name: \n Data Type: \n Unit: \n Sacle Factor: \n\n\n";
            // 
            // Stop
            // 
            this.Stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(0, 183);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(284, 61);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(0, 122);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(284, 61);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Backtoorigin
            // 
            this.Backtoorigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Backtoorigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backtoorigin.Location = new System.Drawing.Point(0, 61);
            this.Backtoorigin.Name = "Backtoorigin";
            this.Backtoorigin.Size = new System.Drawing.Size(284, 61);
            this.Backtoorigin.TabIndex = 1;
            this.Backtoorigin.Text = "Back to Origin";
            this.Backtoorigin.UseVisualStyleBackColor = true;
            // 
            // Calibration
            // 
            this.Calibration.Dock = System.Windows.Forms.DockStyle.Top;
            this.Calibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibration.Location = new System.Drawing.Point(0, 0);
            this.Calibration.Name = "Calibration";
            this.Calibration.Size = new System.Drawing.Size(284, 61);
            this.Calibration.TabIndex = 0;
            this.Calibration.Text = "Calibration";
            this.Calibration.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlPanel.Controls.Add(this.richTextBox_textReceiver);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(284, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(883, 611);
            this.ControlPanel.TabIndex = 2;
            // 
            // richTextBox_textReceiver
            // 
            this.richTextBox_textReceiver.Location = new System.Drawing.Point(20, 174);
            this.richTextBox_textReceiver.Name = "richTextBox_textReceiver";
            this.richTextBox_textReceiver.Size = new System.Drawing.Size(836, 414);
            this.richTextBox_textReceiver.TabIndex = 0;
            this.richTextBox_textReceiver.Text = "";
            // 
            // Arduino_Table_Control
            // 
            this.Arduino_Table_Control.BaudRate = 500000;
            this.Arduino_Table_Control.PortName = "COM3";
            this.Arduino_Table_Control.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Arduino_Table_Control_DataReceived);
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.panel1);
            this.Name = "TableControl";
            this.Size = new System.Drawing.Size(1167, 611);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Backtoorigin;
        private System.Windows.Forms.Button Calibration;
        private System.Windows.Forms.RichTextBox FileProperties;
        private System.Windows.Forms.TextBox ImportFile;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label COM_PORT;
        private System.Windows.Forms.RichTextBox richTextBox_textReceiver;
        private System.IO.Ports.SerialPort Arduino_Table_Control;
    }
}
