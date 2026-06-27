using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter.Views
{
    public partial class OptionForm : Form1
    {
        public OptionForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;

            int width = Properties.Resources.background2.Width + 50;
            int height = Properties.Resources.background2.Height + 200;

            ClientSize = new Size(width, height);

            BackgroundImage = Properties.Resources.OptionBackground2;
            BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void OptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
