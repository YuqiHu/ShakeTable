﻿namespace ShakeTableGUI.UserControls
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Past_GMs.TabIndex = 33;
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
            this.ImportFile.Location = new System.Drawing.Point(102, 337);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(167, 22);
            this.ImportFile.TabIndex = 29;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 335);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 30);
            this.ImportButton.TabIndex = 28;
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
            chartArea1.Name = "ChartArea1";
            this.Time_Disp_Monitor.ChartAreas.Add(chartArea1);
            this.Time_Disp_Monitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Theoretical";
            this.Time_Disp_Monitor.Legends.Add(legend1);
            this.Time_Disp_Monitor.Location = new System.Drawing.Point(0, 311);
            this.Time_Disp_Monitor.Name = "Time_Disp_Monitor";
            this.Time_Disp_Monitor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Theoretical";
            series1.Name = "Serie 1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Time_Disp_Monitor.Series.Add(series1);
            this.Time_Disp_Monitor.Size = new System.Drawing.Size(883, 300);
            this.Time_Disp_Monitor.TabIndex = 2;
            this.Time_Disp_Monitor.Text = "Time_Disp_Monitor";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Time-Displacement";
            this.Time_Disp_Monitor.Titles.Add(title1);
            // 
            // Time_Accel_Monitor
            // 
            chartArea2.Name = "ChartArea1";
            this.Time_Accel_Monitor.ChartAreas.Add(chartArea2);
            this.Time_Accel_Monitor.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Theoretical";
            this.Time_Accel_Monitor.Legends.Add(legend2);
            this.Time_Accel_Monitor.Location = new System.Drawing.Point(0, 0);
            this.Time_Accel_Monitor.Name = "Time_Accel_Monitor";
            this.Time_Accel_Monitor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Theoretical";
            series2.Name = "Serie 1";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Time_Accel_Monitor.Series.Add(series2);
            this.Time_Accel_Monitor.Size = new System.Drawing.Size(883, 300);
            this.Time_Accel_Monitor.TabIndex = 1;
            this.Time_Accel_Monitor.Text = "Time_Accel_Monitor";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Title1";
            title2.Text = "Time-Acceleration";
            this.Time_Accel_Monitor.Titles.Add(title2);
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
    }
}
