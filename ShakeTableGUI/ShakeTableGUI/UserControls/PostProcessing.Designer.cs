namespace ShakeTableGUI.UserControls
{
    partial class PostProcessing
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculateResponseSpectrum = new System.Windows.Forms.Button();
            this.Delimitor = new System.Windows.Forms.Label();
            this.Delimitor_Text = new System.Windows.Forms.TextBox();
            this.RS_TB = new System.Windows.Forms.TextBox();
            this.Import_RS_but = new System.Windows.Forms.Button();
            this.FFT_TB = new System.Windows.Forms.TextBox();
            this.Import_FFT_but = new System.Windows.Forms.Button();
            this.FFT_result_DG = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RS_type_box = new System.Windows.Forms.ComboBox();
            this.damping_ratio_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gamma_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.beta_text = new System.Windows.Forms.TextBox();
            this.exportRS = new System.Windows.Forms.TextBox();
            this.exportRS_butt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.period_step_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.max_period_text = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ExportFSButton = new System.Windows.Forms.Button();
            this.postProcessingPanel = new System.Windows.Forms.Panel();
            this.FFT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RS_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_result_DG)).BeginInit();
            this.postProcessingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.calculateResponseSpectrum);
            this.panel1.Controls.Add(this.Delimitor);
            this.panel1.Controls.Add(this.Delimitor_Text);
            this.panel1.Controls.Add(this.RS_TB);
            this.panel1.Controls.Add(this.Import_RS_but);
            this.panel1.Controls.Add(this.FFT_TB);
            this.panel1.Controls.Add(this.Import_FFT_but);
            this.panel1.Controls.Add(this.FFT_result_DG);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RS_type_box);
            this.panel1.Controls.Add(this.damping_ratio_text);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gamma_text);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.beta_text);
            this.panel1.Controls.Add(this.exportRS);
            this.panel1.Controls.Add(this.exportRS_butt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.period_step_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.max_period_text);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.ExportFSButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 611);
            this.panel1.TabIndex = 2;
            // 
            // calculateResponseSpectrum
            // 
            this.calculateResponseSpectrum.Location = new System.Drawing.Point(16, 272);
            this.calculateResponseSpectrum.Name = "calculateResponseSpectrum";
            this.calculateResponseSpectrum.Size = new System.Drawing.Size(255, 30);
            this.calculateResponseSpectrum.TabIndex = 7;
            this.calculateResponseSpectrum.Text = "Calculate Response Spectrum";
            this.calculateResponseSpectrum.UseVisualStyleBackColor = true;
            this.calculateResponseSpectrum.Click += new System.EventHandler(this.calculateResponseSpectrum_Click);
            // 
            // Delimitor
            // 
            this.Delimitor.AutoSize = true;
            this.Delimitor.Location = new System.Drawing.Point(13, 363);
            this.Delimitor.Name = "Delimitor";
            this.Delimitor.Size = new System.Drawing.Size(60, 16);
            this.Delimitor.TabIndex = 66;
            this.Delimitor.Text = "Delimitor";
            // 
            // Delimitor_Text
            // 
            this.Delimitor_Text.AcceptsTab = true;
            this.Delimitor_Text.Location = new System.Drawing.Point(104, 360);
            this.Delimitor_Text.Name = "Delimitor_Text";
            this.Delimitor_Text.Size = new System.Drawing.Size(167, 22);
            this.Delimitor_Text.TabIndex = 10;
            this.Delimitor_Text.Text = ",";
            // 
            // RS_TB
            // 
            this.RS_TB.Location = new System.Drawing.Point(103, 20);
            this.RS_TB.Name = "RS_TB";
            this.RS_TB.Size = new System.Drawing.Size(167, 22);
            this.RS_TB.TabIndex = 100;
            // 
            // Import_RS_but
            // 
            this.Import_RS_but.Location = new System.Drawing.Point(15, 17);
            this.Import_RS_but.Name = "Import_RS_but";
            this.Import_RS_but.Size = new System.Drawing.Size(75, 30);
            this.Import_RS_but.TabIndex = 0;
            this.Import_RS_but.Text = "Import";
            this.Import_RS_but.UseVisualStyleBackColor = true;
            this.Import_RS_but.Click += new System.EventHandler(this.Import_RS_but_Click);
            // 
            // FFT_TB
            // 
            this.FFT_TB.Location = new System.Drawing.Point(103, 394);
            this.FFT_TB.Name = "FFT_TB";
            this.FFT_TB.Size = new System.Drawing.Size(167, 22);
            this.FFT_TB.TabIndex = 62;
            // 
            // Import_FFT_but
            // 
            this.Import_FFT_but.Location = new System.Drawing.Point(15, 391);
            this.Import_FFT_but.Name = "Import_FFT_but";
            this.Import_FFT_but.Size = new System.Drawing.Size(75, 30);
            this.Import_FFT_but.TabIndex = 11;
            this.Import_FFT_but.Text = "Import";
            this.Import_FFT_but.UseVisualStyleBackColor = true;
            this.Import_FFT_but.Click += new System.EventHandler(this.Import_FFT_but_Click);
            // 
            // FFT_result_DG
            // 
            this.FFT_result_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FFT_result_DG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.FFT_result_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FFT_result_DG.ColumnHeadersVisible = false;
            this.FFT_result_DG.Location = new System.Drawing.Point(14, 430);
            this.FFT_result_DG.Name = "FFT_result_DG";
            this.FFT_result_DG.RowHeadersWidth = 10;
            this.FFT_result_DG.RowTemplate.Height = 24;
            this.FFT_result_DG.Size = new System.Drawing.Size(255, 118);
            this.FFT_result_DG.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Type of Response Spectrum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Type";
            // 
            // RS_type_box
            // 
            this.RS_type_box.FormattingEnabled = true;
            this.RS_type_box.Items.AddRange(new object[] {
            "Acceleration Response Spectrum",
            "Velocity Response Spectrum",
            "Displacement Response Spectrum"});
            this.RS_type_box.Location = new System.Drawing.Point(103, 241);
            this.RS_type_box.Name = "RS_type_box";
            this.RS_type_box.Size = new System.Drawing.Size(166, 24);
            this.RS_type_box.TabIndex = 6;
            // 
            // damping_ratio_text
            // 
            this.damping_ratio_text.Location = new System.Drawing.Point(115, 136);
            this.damping_ratio_text.Name = "damping_ratio_text";
            this.damping_ratio_text.Size = new System.Drawing.Size(155, 22);
            this.damping_ratio_text.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Period Range and Steps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Integration Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Gamma";
            // 
            // gamma_text
            // 
            this.gamma_text.Location = new System.Drawing.Point(208, 189);
            this.gamma_text.Name = "gamma_text";
            this.gamma_text.Size = new System.Drawing.Size(61, 22);
            this.gamma_text.TabIndex = 5;
            this.gamma_text.Text = "0.50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Beta";
            // 
            // beta_text
            // 
            this.beta_text.Location = new System.Drawing.Point(69, 189);
            this.beta_text.Name = "beta_text";
            this.beta_text.Size = new System.Drawing.Size(61, 22);
            this.beta_text.TabIndex = 4;
            this.beta_text.Text = "0.25";
            // 
            // exportRS
            // 
            this.exportRS.Location = new System.Drawing.Point(103, 310);
            this.exportRS.Name = "exportRS";
            this.exportRS.Size = new System.Drawing.Size(167, 22);
            this.exportRS.TabIndex = 49;
            // 
            // exportRS_butt
            // 
            this.exportRS_butt.Location = new System.Drawing.Point(15, 308);
            this.exportRS_butt.Name = "exportRS_butt";
            this.exportRS_butt.Size = new System.Drawing.Size(75, 30);
            this.exportRS_butt.TabIndex = 8;
            this.exportRS_butt.Text = "Export RS";
            this.exportRS_butt.UseVisualStyleBackColor = true;
            this.exportRS_butt.Click += new System.EventHandler(this.exportRS_butt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Damping Ratio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Period Step";
            // 
            // period_step_text
            // 
            this.period_step_text.Location = new System.Drawing.Point(103, 107);
            this.period_step_text.Name = "period_step_text";
            this.period_step_text.Size = new System.Drawing.Size(167, 22);
            this.period_step_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Max. Period";
            // 
            // max_period_text
            // 
            this.max_period_text.Location = new System.Drawing.Point(103, 79);
            this.max_period_text.Name = "max_period_text";
            this.max_period_text.Size = new System.Drawing.Size(167, 22);
            this.max_period_text.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(102, 565);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 22);
            this.textBox5.TabIndex = 19;
            // 
            // ExportFSButton
            // 
            this.ExportFSButton.Location = new System.Drawing.Point(14, 563);
            this.ExportFSButton.Name = "ExportFSButton";
            this.ExportFSButton.Size = new System.Drawing.Size(75, 30);
            this.ExportFSButton.TabIndex = 12;
            this.ExportFSButton.Text = "Export FS";
            this.ExportFSButton.UseVisualStyleBackColor = true;
            // 
            // postProcessingPanel
            // 
            this.postProcessingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postProcessingPanel.Controls.Add(this.FFT_chart);
            this.postProcessingPanel.Controls.Add(this.RS_chart);
            this.postProcessingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postProcessingPanel.Location = new System.Drawing.Point(284, 0);
            this.postProcessingPanel.Name = "postProcessingPanel";
            this.postProcessingPanel.Size = new System.Drawing.Size(883, 611);
            this.postProcessingPanel.TabIndex = 3;
            // 
            // FFT_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.FFT_chart.ChartAreas.Add(chartArea1);
            this.FFT_chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FFT_chart.Location = new System.Drawing.Point(0, 311);
            this.FFT_chart.Name = "FFT_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.FFT_chart.Series.Add(series1);
            this.FFT_chart.Size = new System.Drawing.Size(883, 300);
            this.FFT_chart.TabIndex = 3;
            this.FFT_chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Fourier Analysis";
            this.FFT_chart.Titles.Add(title1);
            // 
            // RS_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.RS_chart.ChartAreas.Add(chartArea2);
            this.RS_chart.Dock = System.Windows.Forms.DockStyle.Top;
            this.RS_chart.Location = new System.Drawing.Point(0, 0);
            this.RS_chart.Name = "RS_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.RS_chart.Series.Add(series2);
            this.RS_chart.Size = new System.Drawing.Size(883, 300);
            this.RS_chart.TabIndex = 2;
            this.RS_chart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Title1";
            title2.Text = "Response Spectrum";
            this.RS_chart.Titles.Add(title2);
            // 
            // PostProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postProcessingPanel);
            this.Controls.Add(this.panel1);
            this.Name = "PostProcessing";
            this.Size = new System.Drawing.Size(1167, 611);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FFT_result_DG)).EndInit();
            this.postProcessingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FFT_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel postProcessingPanel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ExportFSButton;
        private System.Windows.Forms.TextBox damping_ratio_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gamma_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox beta_text;
        private System.Windows.Forms.TextBox exportRS;
        private System.Windows.Forms.Button exportRS_butt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox period_step_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox max_period_text;
        private System.Windows.Forms.DataVisualization.Charting.Chart FFT_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RS_chart;
        private System.Windows.Forms.ComboBox RS_type_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FFT_result_DG;
        private System.Windows.Forms.TextBox RS_TB;
        private System.Windows.Forms.Button Import_RS_but;
        private System.Windows.Forms.TextBox FFT_TB;
        private System.Windows.Forms.Button Import_FFT_but;
        private System.Windows.Forms.Label Delimitor;
        private System.Windows.Forms.TextBox Delimitor_Text;
        private System.Windows.Forms.Button calculateResponseSpectrum;
    }
}
