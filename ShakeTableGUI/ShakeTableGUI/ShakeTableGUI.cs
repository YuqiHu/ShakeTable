using ShakeTableGUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShakeTableGUI
{
    public partial class ShakeTable : Form
    {
        public ShakeTable()
        {
            InitializeComponent();
            Preprocessing pre = new Preprocessing();
            addUserControl(pre);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void Preprocessing_Click(object sender, EventArgs e)
        {
            Preprocessing pre = new Preprocessing();
            addUserControl(pre);
        }

        private void TableControl_Click(object sender, EventArgs e)
        {
            TableControl tc = new TableControl();
            addUserControl(tc);
        }

        private void PostProcessing_Click(object sender, EventArgs e)
        {
            PostProcessing post = new PostProcessing();
            addUserControl(post);
        }

    }
}
