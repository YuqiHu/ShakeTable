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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delimiterText = new System.Windows.Forms.Label();
            this.delimiterOptions = new System.Windows.Forms.ComboBox();
            this.skipHeaderLinesText = new System.Windows.Forms.Label();
            this.skipHeaderLines = new System.Windows.Forms.TextBox();
            this.unitOfAccelerationLabel = new System.Windows.Forms.Label();
            this.unitOfAcceleration = new System.Windows.Forms.ComboBox();
            this.exportFileTextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.timeDisplacementDataGrid = new System.Windows.Forms.DataGridView();
            this.convertToTimeDisplacementButton = new System.Windows.Forms.Button();
            this.timeAccelerationDataGrid = new System.Windows.Forms.DataGridView();
            this.importFileTextBox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.preprocessingPanel = new System.Windows.Forms.Panel();
            this.timeDisplacementChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timeAccelerationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDisplacementDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeAccelerationDataGrid)).BeginInit();
            this.preprocessingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDisplacementChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeAccelerationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delimiterText);
            this.panel1.Controls.Add(this.delimiterOptions);
            this.panel1.Controls.Add(this.skipHeaderLinesText);
            this.panel1.Controls.Add(this.skipHeaderLines);
            this.panel1.Controls.Add(this.unitOfAccelerationLabel);
            this.panel1.Controls.Add(this.unitOfAcceleration);
            this.panel1.Controls.Add(this.exportFileTextBox);
            this.panel1.Controls.Add(this.exportButton);
            this.panel1.Controls.Add(this.timeDisplacementDataGrid);
            this.panel1.Controls.Add(this.convertToTimeDisplacementButton);
            this.panel1.Controls.Add(this.timeAccelerationDataGrid);
            this.panel1.Controls.Add(this.importFileTextBox);
            this.panel1.Controls.Add(this.importButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 611);
            this.panel1.TabIndex = 0;
            // 
            // delimiterText
            // 
            this.delimiterText.AutoSize = true;
            this.delimiterText.Location = new System.Drawing.Point(11, 56);
            this.delimiterText.Name = "delimiterText";
            this.delimiterText.Size = new System.Drawing.Size(60, 16);
            this.delimiterText.TabIndex = 64;
            this.delimiterText.Text = "Delimiter";
            // 
            // delimiterOptions
            // 
            this.delimiterOptions.FormattingEnabled = true;
            this.delimiterOptions.Items.AddRange(new object[] {
            "\\t",
            ",",
            ";"});
            this.delimiterOptions.Location = new System.Drawing.Point(152, 51);
            this.delimiterOptions.Name = "delimiterOptions";
            this.delimiterOptions.Size = new System.Drawing.Size(117, 24);
            this.delimiterOptions.TabIndex = 1;
            // 
            // skipHeaderLinesText
            // 
            this.skipHeaderLinesText.AutoSize = true;
            this.skipHeaderLinesText.Location = new System.Drawing.Point(11, 82);
            this.skipHeaderLinesText.Name = "skipHeaderLinesText";
            this.skipHeaderLinesText.Size = new System.Drawing.Size(118, 16);
            this.skipHeaderLinesText.TabIndex = 62;
            this.skipHeaderLinesText.Text = "Skip Header Lines";
            // 
            // skipHeaderLines
            // 
            this.skipHeaderLines.Location = new System.Drawing.Point(152, 80);
            this.skipHeaderLines.Name = "skipHeaderLines";
            this.skipHeaderLines.Size = new System.Drawing.Size(117, 22);
            this.skipHeaderLines.TabIndex = 2;
            // 
            // unitOfAccelerationLabel
            // 
            this.unitOfAccelerationLabel.AutoSize = true;
            this.unitOfAccelerationLabel.Location = new System.Drawing.Point(11, 27);
            this.unitOfAccelerationLabel.Name = "unitOfAccelerationLabel";
            this.unitOfAccelerationLabel.Size = new System.Drawing.Size(122, 16);
            this.unitOfAccelerationLabel.TabIndex = 60;
            this.unitOfAccelerationLabel.Text = "Unit of Acceleration";
            // 
            // unitOfAcceleration
            // 
            this.unitOfAcceleration.FormattingEnabled = true;
            this.unitOfAcceleration.Items.AddRange(new object[] {
            "g",
            "m/s^2"});
            this.unitOfAcceleration.Location = new System.Drawing.Point(152, 22);
            this.unitOfAcceleration.Name = "unitOfAcceleration";
            this.unitOfAcceleration.Size = new System.Drawing.Size(117, 24);
            this.unitOfAcceleration.TabIndex = 0;
            // 
            // exportFileTextBox
            // 
            this.exportFileTextBox.Location = new System.Drawing.Point(102, 566);
            this.exportFileTextBox.Name = "exportFileTextBox";
            this.exportFileTextBox.Size = new System.Drawing.Size(167, 22);
            this.exportFileTextBox.TabIndex = 32;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(14, 564);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 30);
            this.exportButton.TabIndex = 21;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportFSButton_Click);
            // 
            // timeDisplacementDataGrid
            // 
            this.timeDisplacementDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeDisplacementDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeDisplacementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeDisplacementDataGrid.Location = new System.Drawing.Point(14, 364);
            this.timeDisplacementDataGrid.Name = "timeDisplacementDataGrid";
            this.timeDisplacementDataGrid.RowHeadersWidth = 10;
            this.timeDisplacementDataGrid.RowTemplate.Height = 24;
            this.timeDisplacementDataGrid.Size = new System.Drawing.Size(255, 181);
            this.timeDisplacementDataGrid.TabIndex = 30;
            // 
            // convertToTimeDisplacementButton
            // 
            this.convertToTimeDisplacementButton.Location = new System.Drawing.Point(14, 311);
            this.convertToTimeDisplacementButton.Name = "convertToTimeDisplacementButton";
            this.convertToTimeDisplacementButton.Size = new System.Drawing.Size(255, 35);
            this.convertToTimeDisplacementButton.TabIndex = 11;
            this.convertToTimeDisplacementButton.Text = "Convert to Time-Displacement";
            this.convertToTimeDisplacementButton.UseVisualStyleBackColor = true;
            this.convertToTimeDisplacementButton.Click += new System.EventHandler(this.Convert_ta_ts_Click);
            // 
            // timeAccelerationDataGrid
            // 
            this.timeAccelerationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeAccelerationDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeAccelerationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeAccelerationDataGrid.Location = new System.Drawing.Point(14, 152);
            this.timeAccelerationDataGrid.Name = "timeAccelerationDataGrid";
            this.timeAccelerationDataGrid.RowHeadersWidth = 10;
            this.timeAccelerationDataGrid.RowTemplate.Height = 24;
            this.timeAccelerationDataGrid.Size = new System.Drawing.Size(255, 138);
            this.timeAccelerationDataGrid.TabIndex = 0;
            // 
            // importFileTextBox
            // 
            this.importFileTextBox.Location = new System.Drawing.Point(102, 109);
            this.importFileTextBox.Name = "importFileTextBox";
            this.importFileTextBox.Size = new System.Drawing.Size(167, 22);
            this.importFileTextBox.TabIndex = 27;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(14, 106);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 30);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // preprocessingPanel
            // 
            this.preprocessingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.preprocessingPanel.Controls.Add(this.timeDisplacementChart);
            this.preprocessingPanel.Controls.Add(this.timeAccelerationChart);
            this.preprocessingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preprocessingPanel.Location = new System.Drawing.Point(284, 0);
            this.preprocessingPanel.Name = "preprocessingPanel";
            this.preprocessingPanel.Size = new System.Drawing.Size(883, 611);
            this.preprocessingPanel.TabIndex = 1;
            // 
            // timeDisplacementChart
            // 
            chartArea1.Name = "ChartArea1";
            this.timeDisplacementChart.ChartAreas.Add(chartArea1);
            this.timeDisplacementChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeDisplacementChart.Location = new System.Drawing.Point(0, 311);
            this.timeDisplacementChart.Name = "timeDisplacementChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.timeDisplacementChart.Series.Add(series1);
            this.timeDisplacementChart.Size = new System.Drawing.Size(883, 300);
            this.timeDisplacementChart.TabIndex = 3;
            this.timeDisplacementChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Time-Displacement";
            this.timeDisplacementChart.Titles.Add(title1);
            // 
            // timeAccelerationChart
            // 
            chartArea2.Name = "ChartArea1";
            this.timeAccelerationChart.ChartAreas.Add(chartArea2);
            this.timeAccelerationChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.timeAccelerationChart.Legends.Add(legend1);
            this.timeAccelerationChart.Location = new System.Drawing.Point(0, 0);
            this.timeAccelerationChart.Name = "timeAccelerationChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Serie 1";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.timeAccelerationChart.Series.Add(series2);
            this.timeAccelerationChart.Size = new System.Drawing.Size(883, 300);
            this.timeAccelerationChart.TabIndex = 0;
            this.timeAccelerationChart.Text = "Time_Acceleration";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Title1";
            title2.Text = "Time-Acceleration";
            this.timeAccelerationChart.Titles.Add(title2);
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
            ((System.ComponentModel.ISupportInitialize)(this.timeDisplacementDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeAccelerationDataGrid)).EndInit();
            this.preprocessingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeDisplacementChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeAccelerationChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel preprocessingPanel;
        private System.Windows.Forms.TextBox importFileTextBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.DataGridView timeAccelerationDataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeAccelerationChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeDisplacementChart;
        private System.Windows.Forms.Button convertToTimeDisplacementButton;
        private System.Windows.Forms.DataGridView timeDisplacementDataGrid;
        private System.Windows.Forms.TextBox exportFileTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label unitOfAccelerationLabel;
        private System.Windows.Forms.ComboBox unitOfAcceleration;
        private System.Windows.Forms.Label skipHeaderLinesText;
        private System.Windows.Forms.TextBox skipHeaderLines;
        private System.Windows.Forms.Label delimiterText;
        private System.Windows.Forms.ComboBox delimiterOptions;
    }
}
