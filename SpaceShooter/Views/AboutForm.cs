using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter.Views
{
    public partial class AboutForm : Form1
    {
        public AboutForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            int width = Properties.Resources.background2.Width + 50;
            int height = Properties.Resources.background2.Height + 200;

            ClientSize = new Size(width, height);

            BackgroundImage = Properties.Resources.aboutBackground3;
            BackgroundImageLayout = ImageLayout.Stretch;

            DoubleBuffered = true;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
