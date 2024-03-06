namespace GUI
{
    partial class ShakeTableController
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.BacktoOrigin = new System.Windows.Forms.Button();
            this.Calibrate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Preprocessing = new System.Windows.Forms.Button();
            this.Controller = new System.Windows.Forms.Button();
            this.Postprocessing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.Stop);
            this.panel2.Controls.Add(this.Start);
            this.panel2.Controls.Add(this.BacktoOrigin);
            this.panel2.Controls.Add(this.Calibrate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 613);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 228);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 385);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = " File: \n Name: \n Data Type: \n Unit: \n Sacle Factor: \n\n\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(0, 171);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(262, 57);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(0, 114);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(262, 57);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button6_Click);
            // 
            // BacktoOrigin
            // 
            this.BacktoOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BacktoOrigin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BacktoOrigin.FlatAppearance.BorderSize = 0;
            this.BacktoOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoOrigin.Location = new System.Drawing.Point(0, 57);
            this.BacktoOrigin.Name = "BacktoOrigin";
            this.BacktoOrigin.Size = new System.Drawing.Size(262, 57);
            this.BacktoOrigin.TabIndex = 1;
            this.BacktoOrigin.Text = "Back to Origin";
            this.BacktoOrigin.UseVisualStyleBackColor = true;
            // 
            // Calibrate
            // 
            this.Calibrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Calibrate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Calibrate.FlatAppearance.BorderSize = 0;
            this.Calibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibrate.Location = new System.Drawing.Point(0, 0);
            this.Calibrate.Name = "Calibrate";
            this.Calibrate.Size = new System.Drawing.Size(262, 57);
            this.Calibrate.TabIndex = 0;
            this.Calibrate.Text = "Calibrate";
            this.Calibrate.UseVisualStyleBackColor = true;
            this.Calibrate.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.Title = "Time";
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisY.Title = "Acceleration";
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Location = new System.Drawing.Point(268, 41);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(897, 201);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Time-Acceleration";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "Time-Acceleration";
            this.chart1.Titles.Add(title7);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.Title = "Time";
            chartArea8.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisY.Title = "Displacement";
            chartArea8.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            this.chart2.Location = new System.Drawing.Point(268, 243);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsVisibleInLegend = false;
            series8.Name = "Series1";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(897, 201);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "Time-Acceleration";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "Time-Displacement";
            this.chart2.Titles.Add(title8);
            // 
            // chart3
            // 
            this.chart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart3.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.Title = "Time";
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY.Title = "Displacement";
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            this.chart3.Location = new System.Drawing.Point(268, 445);
            this.chart3.Name = "chart3";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsVisibleInLegend = false;
            series9.Name = "Series1";
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(897, 201);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "Time-Acceleration";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "Title1";
            title9.Text = "Monitored Table Displacement";
            this.chart3.Titles.Add(title9);
            // 
            // Preprocessing
            // 
            this.Preprocessing.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Preprocessing.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preprocessing.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Preprocessing.FlatAppearance.BorderSize = 0;
            this.Preprocessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preprocessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preprocessing.Location = new System.Drawing.Point(0, 0);
            this.Preprocessing.Name = "Preprocessing";
            this.Preprocessing.Size = new System.Drawing.Size(200, 40);
            this.Preprocessing.TabIndex = 0;
            this.Preprocessing.Text = "Pre-processing";
            this.Preprocessing.UseVisualStyleBackColor = false;
            // 
            // Controller
            // 
            this.Controller.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controller.Dock = System.Windows.Forms.DockStyle.Left;
            this.Controller.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Controller.FlatAppearance.BorderSize = 0;
            this.Controller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Controller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controller.Location = new System.Drawing.Point(200, 0);
            this.Controller.Name = "Controller";
            this.Controller.Size = new System.Drawing.Size(200, 40);
            this.Controller.TabIndex = 1;
            this.Controller.Text = "Controller";
            this.Controller.UseVisualStyleBackColor = false;
            // 
            // Postprocessing
            // 
            this.Postprocessing.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Postprocessing.Dock = System.Windows.Forms.DockStyle.Left;
            this.Postprocessing.FlatAppearance.BorderSize = 0;
            this.Postprocessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Postprocessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postprocessing.Location = new System.Drawing.Point(400, 0);
            this.Postprocessing.Name = "Postprocessing";
            this.Postprocessing.Size = new System.Drawing.Size(200, 40);
            this.Postprocessing.TabIndex = 2;
            this.Postprocessing.Text = "Post-processing";
            this.Postprocessing.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.Postprocessing);
            this.panel1.Controls.Add(this.Controller);
            this.panel1.Controls.Add(this.Preprocessing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 40);
            this.panel1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShakeTableController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ShakeTableController";
            this.RightToLeftLayout = true;
            this.Text = "UTSD Shake Table";
            this.Load += new System.EventHandler(this.ShakeTableController_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Calibrate;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button BacktoOrigin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button Preprocessing;
        private System.Windows.Forms.Button Controller;
        private System.Windows.Forms.Button Postprocessing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

