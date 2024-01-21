namespace GUI
{
    partial class ShakeTableController
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 63);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Dock = DockStyle.Left;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(500, 0);
            button3.Name = "button3";
            button3.Size = new Size(250, 63);
            button3.TabIndex = 2;
            button3.Text = "Post-Processing";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Dock = DockStyle.Left;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(250, 0);
            button2.Name = "button2";
            button2.Size = new Size(250, 63);
            button2.TabIndex = 1;
            button2.Text = "Pre-Processing";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 63);
            button1.TabIndex = 0;
            button1.Text = "Shake Table Controller";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 670);
            panel2.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Info;
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 225);
            button7.Name = "button7";
            button7.Size = new Size(250, 75);
            button7.TabIndex = 3;
            button7.Text = "Stop";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Info;
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 150);
            button6.Name = "button6";
            button6.Size = new Size(250, 75);
            button6.TabIndex = 2;
            button6.Text = "Start";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 75);
            button5.Name = "button5";
            button5.Size = new Size(250, 75);
            button5.TabIndex = 1;
            button5.Text = "Back to Origin";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(250, 75);
            button4.TabIndex = 0;
            button4.Text = "Calibrate";
            button4.UseVisualStyleBackColor = false;
            // 
            // ShakeTableController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 733);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ShakeTableController";
            Text = "UTSD Shake Table";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;

    }
}
