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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RS_type_box = new System.Windows.Forms.ComboBox();
            this.damping_ratio = new System.Windows.Forms.TextBox();
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
            this.period_step = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.max_period_text = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ExportFSButton = new System.Windows.Forms.Button();
            this.postProcessingPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RS_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.postProcessingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RS_type_box);
            this.panel1.Controls.Add(this.damping_ratio);
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
            this.panel1.Controls.Add(this.period_step);
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
            // RS_type_box
            // 
            this.RS_type_box.FormattingEnabled = true;
            this.RS_type_box.Location = new System.Drawing.Point(103, 231);
            this.RS_type_box.Name = "RS_type_box";
            this.RS_type_box.Size = new System.Drawing.Size(166, 24);
            this.RS_type_box.TabIndex = 57;
            this.RS_type_box.SelectedIndexChanged += new System.EventHandler(this.RS_type_box_SelectedIndexChanged);
            // 
            // damping_ratio
            // 
            this.damping_ratio.Location = new System.Drawing.Point(115, 98);
            this.damping_ratio.Name = "damping_ratio";
            this.damping_ratio.Size = new System.Drawing.Size(155, 22);
            this.damping_ratio.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Period Range and Steps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Integration Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Gamma";
            // 
            // gamma_text
            // 
            this.gamma_text.Location = new System.Drawing.Point(103, 179);
            this.gamma_text.Name = "gamma_text";
            this.gamma_text.Size = new System.Drawing.Size(167, 22);
            this.gamma_text.TabIndex = 52;
            this.gamma_text.Text = "0.50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Beta";
            // 
            // beta_text
            // 
            this.beta_text.Location = new System.Drawing.Point(103, 151);
            this.beta_text.Name = "beta_text";
            this.beta_text.Size = new System.Drawing.Size(167, 22);
            this.beta_text.TabIndex = 50;
            this.beta_text.Text = "0.25";
            // 
            // exportRS
            // 
            this.exportRS.Location = new System.Drawing.Point(103, 272);
            this.exportRS.Name = "exportRS";
            this.exportRS.Size = new System.Drawing.Size(167, 22);
            this.exportRS.TabIndex = 49;
            // 
            // exportRS_butt
            // 
            this.exportRS_butt.Location = new System.Drawing.Point(15, 270);
            this.exportRS_butt.Name = "exportRS_butt";
            this.exportRS_butt.Size = new System.Drawing.Size(75, 30);
            this.exportRS_butt.TabIndex = 48;
            this.exportRS_butt.Text = "Export RS";
            this.exportRS_butt.UseVisualStyleBackColor = true;
            this.exportRS_butt.Click += new System.EventHandler(this.exportRS_butt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Damping Ratio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Period Step";
            // 
            // period_step
            // 
            this.period_step.Location = new System.Drawing.Point(103, 69);
            this.period_step.Name = "period_step";
            this.period_step.Size = new System.Drawing.Size(167, 22);
            this.period_step.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Max. Period";
            // 
            // max_period_text
            // 
            this.max_period_text.Location = new System.Drawing.Point(103, 41);
            this.max_period_text.Name = "max_period_text";
            this.max_period_text.Size = new System.Drawing.Size(167, 22);
            this.max_period_text.TabIndex = 43;
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
            this.ExportFSButton.TabIndex = 18;
            this.ExportFSButton.Text = "Export FS";
            this.ExportFSButton.UseVisualStyleBackColor = true;
            // 
            // postProcessingPanel
            // 
            this.postProcessingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postProcessingPanel.Controls.Add(this.chart1);
            this.postProcessingPanel.Controls.Add(this.RS_chart);
            this.postProcessingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postProcessingPanel.Location = new System.Drawing.Point(284, 0);
            this.postProcessingPanel.Name = "postProcessingPanel";
            this.postProcessingPanel.Size = new System.Drawing.Size(883, 611);
            this.postProcessingPanel.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(0, 311);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(883, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title3.Name = "Title1";
            title3.Text = "Fourier Analysis";
            this.chart1.Titles.Add(title3);
            // 
            // RS_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.RS_chart.ChartAreas.Add(chartArea4);
            this.RS_chart.Dock = System.Windows.Forms.DockStyle.Top;
            this.RS_chart.Location = new System.Drawing.Point(0, 0);
            this.RS_chart.Name = "RS_chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.RS_chart.Series.Add(series4);
            this.RS_chart.Size = new System.Drawing.Size(883, 300);
            this.RS_chart.TabIndex = 2;
            this.RS_chart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title4.Name = "Title1";
            title4.Text = "Response Spectrum";
            this.RS_chart.Titles.Add(title4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Type of Response Spectrum";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(255, 181);
            this.dataGridView1.TabIndex = 60;
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
            this.postProcessingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel postProcessingPanel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ExportFSButton;
        private System.Windows.Forms.TextBox damping_ratio;
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
        private System.Windows.Forms.TextBox period_step;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox max_period_text;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart RS_chart;
        private System.Windows.Forms.ComboBox RS_type_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
