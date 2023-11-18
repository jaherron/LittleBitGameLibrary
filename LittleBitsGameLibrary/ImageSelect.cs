using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleBitsGameLibrary
{
    public partial class ImageSelect : Form
    {
        public ImageSelect()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            imageOpenDialog.ShowDialog();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }

        private void imageOpenDialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = imageOpenDialog.FileName;
        }
    }
}
