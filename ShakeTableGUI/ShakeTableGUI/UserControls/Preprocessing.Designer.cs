namespace ShakeTableGUI.UserControls
{
    partial class Preprocessing
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ExportFSButton = new System.Windows.Forms.Button();
            this.td_DG = new System.Windows.Forms.DataGridView();
            this.Convert_ta_ts = new System.Windows.Forms.Button();
            this.ImportDG = new System.Windows.Forms.DataGridView();
            this.ImportFile = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.preprocessingPanel = new System.Windows.Forms.Panel();
            this.Time_Disp_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ta_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.td_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportDG)).BeginInit();
            this.preprocessingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Disp_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ta_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.ExportFSButton);
            this.panel1.Controls.Add(this.td_DG);
            this.panel1.Controls.Add(this.Convert_ta_ts);
            this.panel1.Controls.Add(this.ImportDG);
            this.panel1.Controls.Add(this.ImportFile);
            this.panel1.Controls.Add(this.ImportButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 611);
            this.panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(102, 566);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 22);
            this.textBox5.TabIndex = 32;
            // 
            // ExportFSButton
            // 
            this.ExportFSButton.Location = new System.Drawing.Point(14, 564);
            this.ExportFSButton.Name = "ExportFSButton";
            this.ExportFSButton.Size = new System.Drawing.Size(75, 30);
            this.ExportFSButton.TabIndex = 31;
            this.ExportFSButton.Text = "Export";
            this.ExportFSButton.UseVisualStyleBackColor = true;
            // 
            // td_DG
            // 
            this.td_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.td_DG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.td_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.td_DG.ColumnHeadersVisible = false;
            this.td_DG.Location = new System.Drawing.Point(14, 364);
            this.td_DG.Name = "td_DG";
            this.td_DG.RowHeadersWidth = 10;
            this.td_DG.RowTemplate.Height = 24;
            this.td_DG.Size = new System.Drawing.Size(255, 181);
            this.td_DG.TabIndex = 30;
            // 
            // Convert_ta_ts
            // 
            this.Convert_ta_ts.Location = new System.Drawing.Point(14, 254);
            this.Convert_ta_ts.Name = "Convert_ta_ts";
            this.Convert_ta_ts.Size = new System.Drawing.Size(255, 35);
            this.Convert_ta_ts.TabIndex = 29;
            this.Convert_ta_ts.Text = "Convert to Time-Displacement";
            this.Convert_ta_ts.UseVisualStyleBackColor = true;
            this.Convert_ta_ts.Click += new System.EventHandler(this.Convert_ta_ts_Click);
            // 
            // ImportDG
            // 
            this.ImportDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ImportDG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImportDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportDG.ColumnHeadersVisible = false;
            this.ImportDG.Location = new System.Drawing.Point(14, 62);
            this.ImportDG.Name = "ImportDG";
            this.ImportDG.RowHeadersWidth = 10;
            this.ImportDG.RowTemplate.Height = 24;
            this.ImportDG.Size = new System.Drawing.Size(255, 171);
            this.ImportDG.TabIndex = 0;
            this.ImportDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImportDG_CellContentClick);
            // 
            // ImportFile
            // 
            this.ImportFile.Location = new System.Drawing.Point(102, 21);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(167, 22);
            this.ImportFile.TabIndex = 27;
            this.ImportFile.TextChanged += new System.EventHandler(this.ImportFile_TextChanged);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 19);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 30);
            this.ImportButton.TabIndex = 22;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // preprocessingPanel
            // 
            this.preprocessingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.preprocessingPanel.Controls.Add(this.Time_Disp_chart);
            this.preprocessingPanel.Controls.Add(this.ta_chart);
            this.preprocessingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preprocessingPanel.Location = new System.Drawing.Point(284, 0);
            this.preprocessingPanel.Name = "preprocessingPanel";
            this.preprocessingPanel.Size = new System.Drawing.Size(883, 611);
            this.preprocessingPanel.TabIndex = 1;
            // 
            // Time_Disp_chart
            // 
            chartArea11.Name = "ChartArea1";
            this.Time_Disp_chart.ChartAreas.Add(chartArea11);
            this.Time_Disp_chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Time_Disp_chart.Location = new System.Drawing.Point(0, 311);
            this.Time_Disp_chart.Name = "Time_Disp_chart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Series1";
            this.Time_Disp_chart.Series.Add(series11);
            this.Time_Disp_chart.Size = new System.Drawing.Size(883, 300);
            this.Time_Disp_chart.TabIndex = 3;
            this.Time_Disp_chart.Text = "chart1";
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title11.Name = "Title1";
            title11.Text = "Time-Displacement";
            this.Time_Disp_chart.Titles.Add(title11);
            // 
            // ta_chart
            // 
            chartArea12.Name = "ChartArea1";
            this.ta_chart.ChartAreas.Add(chartArea12);
            this.ta_chart.Dock = System.Windows.Forms.DockStyle.Top;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.ta_chart.Legends.Add(legend6);
            this.ta_chart.Location = new System.Drawing.Point(0, 0);
            this.ta_chart.Name = "ta_chart";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.Name = "Serie 1";
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.ta_chart.Series.Add(series12);
            this.ta_chart.Size = new System.Drawing.Size(883, 300);
            this.ta_chart.TabIndex = 0;
            this.ta_chart.Text = "Time_Acceleration";
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title12.Name = "Title1";
            title12.Text = "Time-Acceleration";
            this.ta_chart.Titles.Add(title12);
            // 
            // Preprocessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.preprocessingPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Preprocessing";
            this.Size = new System.Drawing.Size(1167, 611);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.td_DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportDG)).EndInit();
            this.preprocessingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Time_Disp_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ta_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel preprocessingPanel;
        private System.Windows.Forms.TextBox ImportFile;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.DataGridView ImportDG;
        private System.Windows.Forms.DataVisualization.Charting.Chart ta_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Time_Disp_chart;
        private System.Windows.Forms.Button Convert_ta_ts;
        private System.Windows.Forms.DataGridView td_DG;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ExportFSButton;
    }
}
