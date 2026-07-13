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

            pictureBox1.Image = AudioManager.IsMusicMuted ? Properties.Resources.sound2 : Properties.Resources.sound1;
            pictureBox2.Image = AudioManager.IsSfxMuted ? Properties.Resources.sound2 : Properties.Resources.sound1;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            AudioManager.IsMusicMuted = !AudioManager.IsMusicMuted;
            if (AudioManager.IsMusicMuted)
            {
                pictureBox1.Image = Properties.Resources.sound2;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.sound1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AudioManager.IsSfxMuted = !AudioManager.IsSfxMuted;
            AudioManager.PlaySfx(Properties.Resources.gameClick);

            if (AudioManager.IsSfxMuted)
            {
                pictureBox2.Image = Properties.Resources.sound2;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.sound1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.click);
            Close();
        }
    }
}

