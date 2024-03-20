using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ShakeTableGUI.UserControls
{
    public partial class Preprocessing : UserControl
    {
        public Preprocessing()
        {
            InitializeComponent();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browser Text File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportFile.Text = openFileDialog1.FileName;
                ImportHelper.file = ImportFile.Text;

                ImportDG.DataSource = ImportHelper.DataTableFromTextFile(ImportFile.Text);
            }
        }

        private void ImportFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
