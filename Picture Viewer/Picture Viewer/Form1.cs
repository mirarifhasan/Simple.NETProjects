using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchCheckBox.Checked)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
