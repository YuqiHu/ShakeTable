namespace ShakeTableGUI
{
    partial class ShakeTable
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
            this.NameBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.PostProcessing = new System.Windows.Forms.Button();
            this.TableControl = new System.Windows.Forms.Button();
            this.Preprocessing = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.NameBar.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBar
            // 
            this.NameBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.NameBar.Controls.Add(this.label1);
            this.NameBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameBar.Location = new System.Drawing.Point(0, 0);
            this.NameBar.Name = "NameBar";
            this.NameBar.Size = new System.Drawing.Size(1167, 45);
            this.NameBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "University of Toronto Seismic Design Team Shake Table";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu.Controls.Add(this.PostProcessing);
            this.Menu.Controls.Add(this.TableControl);
            this.Menu.Controls.Add(this.Preprocessing);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 45);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1167, 58);
            this.Menu.TabIndex = 1;
            // 
            // PostProcessing
            // 
            this.PostProcessing.Dock = System.Windows.Forms.DockStyle.Left;
            this.PostProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostProcessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.PostProcessing.Location = new System.Drawing.Point(432, 0);
            this.PostProcessing.Name = "PostProcessing";
            this.PostProcessing.Size = new System.Drawing.Size(216, 58);
            this.PostProcessing.TabIndex = 2;
            this.PostProcessing.Text = "Post-processing";
            this.PostProcessing.UseVisualStyleBackColor = true;
            this.PostProcessing.Click += new System.EventHandler(this.PostProcessing_Click);
            // 
            // TableControl
            // 
            this.TableControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.TableControl.Location = new System.Drawing.Point(216, 0);
            this.TableControl.Name = "TableControl";
            this.TableControl.Size = new System.Drawing.Size(216, 58);
            this.TableControl.TabIndex = 1;
            this.TableControl.Text = "Table Control";
            this.TableControl.UseVisualStyleBackColor = true;
            this.TableControl.Click += new System.EventHandler(this.TableControl_Click);
            // 
            // Preprocessing
            // 
            this.Preprocessing.Dock = System.Windows.Forms.DockStyle.Left;
            this.Preprocessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preprocessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.Preprocessing.Location = new System.Drawing.Point(0, 0);
            this.Preprocessing.Name = "Preprocessing";
            this.Preprocessing.Size = new System.Drawing.Size(216, 58);
            this.Preprocessing.TabIndex = 0;
            this.Preprocessing.Text = "Pre-processing";
            this.Preprocessing.UseVisualStyleBackColor = true;
            this.Preprocessing.Click += new System.EventHandler(this.Preprocessing_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 103);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1167, 611);
            this.PanelContainer.TabIndex = 2;
            // 
            // Arduino
            // 
            this.Arduino.BaudRate = 500000;
            this.Arduino.PortName = "COM3";
            this.Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Arduino_DataReceived);
            // 
            // ShakeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 714);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.NameBar);
            this.Name = "ShakeTable";
            this.Text = "University of Toronto Seismic Design Team Shake Table";
            this.Load += new System.EventHandler(this.ShakeTable_Load);
            this.NameBar.ResumeLayout(false);
            this.NameBar.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NameBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Button Preprocessing;
        private System.Windows.Forms.Button PostProcessing;
        private System.Windows.Forms.Button TableControl;
        private System.IO.Ports.SerialPort Arduino;
    }
}

