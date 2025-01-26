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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timestepsText = new System.Windows.Forms.Label();
            this.timesteps = new System.Windows.Forms.TextBox();
            this.Past_GMs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.COM_PORT = new System.Windows.Forms.Label();
            this.ImportFile = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Backtoorigin = new System.Windows.Forms.Button();
            this.Calibration = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Time_Disp_Monitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Time_Accel_Monitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Arduino_Table_Control = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Disp_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Accel_Monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timestepsText);
            this.panel1.Controls.Add(this.timesteps);
            this.panel1.Controls.Add(this.Past_GMs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_comPort);
            this.panel1.Controls.Add(this.COM_PORT);
            this.panel1.Controls.Add(this.ImportFile);
            this.panel1.Controls.Add(this.ImportButton);
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
            // timestepsText
            // 
            this.timestepsText.AutoSize = true;
            this.timestepsText.Location = new System.Drawing.Point(11, 326);
            this.timestepsText.Name = "timestepsText";
            this.timestepsText.Size = new System.Drawing.Size(89, 16);
            this.timestepsText.TabIndex = 64;
            this.timestepsText.Text = "Timesteps (s)";
            // 
            // timesteps
            // 
            this.timesteps.Location = new System.Drawing.Point(102, 323);
            this.timesteps.Name = "timesteps";
            this.timesteps.Size = new System.Drawing.Size(169, 22);
            this.timesteps.TabIndex = 13;
            // 
            // Past_GMs
            // 
            this.Past_GMs.FormattingEnabled = true;
            this.Past_GMs.Items.AddRange(new object[] {
            "Sine Sweep Test",
            "White Noise Test",
            "Pink Noise Test",
            "2020 GM1",
            "2020 GM2",
            "2022 GM1",
            "2022 GM2",
            "2023 GM1",
            "2023 GM2",
            "2024 GM1",
            "1940 El-Centro Earthquake",
            "1995 Kobe Earthquake"});
            this.Past_GMs.Location = new System.Drawing.Point(102, 292);
            this.Past_GMs.Name = "Past_GMs";
            this.Past_GMs.Size = new System.Drawing.Size(167, 24);
            this.Past_GMs.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Past GMs:";
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(102, 258);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(167, 24);
            this.comboBox_comPort.TabIndex = 11;
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
            this.ImportFile.Location = new System.Drawing.Point(102, 363);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(167, 22);
            this.ImportFile.TabIndex = 29;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 361);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 30);
            this.ImportButton.TabIndex = 14;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
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
            this.ControlPanel.Controls.Add(this.Time_Disp_Monitor);
            this.ControlPanel.Controls.Add(this.Time_Accel_Monitor);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(284, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(883, 611);
            this.ControlPanel.TabIndex = 2;
            // 
            // Time_Disp_Monitor
            // 
            chartArea5.Name = "ChartArea1";
            this.Time_Disp_Monitor.ChartAreas.Add(chartArea5);
            this.Time_Disp_Monitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend5.DockedToChartArea = "ChartArea1";
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Theoretical";
            this.Time_Disp_Monitor.Legends.Add(legend5);
            this.Time_Disp_Monitor.Location = new System.Drawing.Point(0, 311);
            this.Time_Disp_Monitor.Name = "Time_Disp_Monitor";
            this.Time_Disp_Monitor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Theoretical";
            series5.Name = "Serie 1";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Time_Disp_Monitor.Series.Add(series5);
            this.Time_Disp_Monitor.Size = new System.Drawing.Size(883, 300);
            this.Time_Disp_Monitor.TabIndex = 2;
            this.Time_Disp_Monitor.Text = "Time_Disp_Monitor";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title5.Name = "Title1";
            title5.Text = "Time-Displacement";
            this.Time_Disp_Monitor.Titles.Add(title5);
            // 
            // Time_Accel_Monitor
            // 
            chartArea6.Name = "ChartArea1";
            this.Time_Accel_Monitor.ChartAreas.Add(chartArea6);
            this.Time_Accel_Monitor.Dock = System.Windows.Forms.DockStyle.Top;
            legend6.DockedToChartArea = "ChartArea1";
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Name = "Theoretical";
            this.Time_Accel_Monitor.Legends.Add(legend6);
            this.Time_Accel_Monitor.Location = new System.Drawing.Point(0, 0);
            this.Time_Accel_Monitor.Name = "Time_Accel_Monitor";
            this.Time_Accel_Monitor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Theoretical";
            series6.Name = "Serie 1";
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Time_Accel_Monitor.Series.Add(series6);
            this.Time_Accel_Monitor.Size = new System.Drawing.Size(883, 300);
            this.Time_Accel_Monitor.TabIndex = 1;
            this.Time_Accel_Monitor.Text = "Time_Accel_Monitor";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title6.Name = "Title1";
            title6.Text = "Time-Acceleration";
            this.Time_Accel_Monitor.Titles.Add(title6);
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
            ((System.ComponentModel.ISupportInitialize)(this.Time_Disp_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Accel_Monitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Backtoorigin;
        private System.Windows.Forms.Button Calibration;
        private System.Windows.Forms.TextBox ImportFile;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label COM_PORT;
        private System.IO.Ports.SerialPort Arduino_Table_Control;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Time_Disp_Monitor;
        private System.Windows.Forms.DataVisualization.Charting.Chart Time_Accel_Monitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Past_GMs;
        private System.Windows.Forms.Label timestepsText;
        private System.Windows.Forms.TextBox timesteps;
    }
}
