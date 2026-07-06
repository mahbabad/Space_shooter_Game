using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter.Views
{
    public partial class MainMenuForm : Form1
    {
        System.Windows.Forms.Timer timer;
        
        public MainMenuForm()
        {
            InitializeComponent();
            MainForm();
            buttonPlay.Visible = false;
            buttonShop.Visible = false;
            buttonOption.Visible = false;
            buttonAbout.Visible = false;
            SayWelcome();
            MenuButten();

            StartMusic();
            
        }
        void SayWelcome()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        void TimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            labelWelcome.Visible = false;
            buttonPlay.Visible = true;
            buttonShop.Visible = true;
            buttonOption.Visible = true;
            buttonAbout.Visible = true;
        }

        void MenuButten()
        {
            buttonPlay.Click += (s, e) =>
            {
                Hide();
                GameForm gameForm = new GameForm();
                gameForm.ShowIcon = false;
                gameForm.ShowInTaskbar = false;
                DialogResult result = gameForm.ShowDialog();
                if (result == DialogResult.Abort)
                {
                    Application.Exit();
                    return;
                }
                Show();
                StartMusic();
            };

            buttonOption.Click += (s, e) =>
            {
                Hide();
                OptionForm optionForm = new OptionForm();
                optionForm.ShowIcon = false;
                optionForm.ShowInTaskbar = false;
                optionForm.ShowDialog();
                Show();

            };

            buttonShop.Click += (s, e) =>
            {
                Hide();
                ShopForm shopForm = new ShopForm();
                shopForm.ShowIcon = false;
                shopForm.ShowInTaskbar = false;
                shopForm.ShowDialog();
                Show();
                StartMusic();

            };

            buttonAbout.Click += (s, e) =>
            {
                Hide();
                AboutForm aboutForm = new AboutForm();
                aboutForm.ShowIcon = false;
                aboutForm.ShowInTaskbar = false;
                aboutForm.ShowDialog();
                Show();
                StartMusic();
            };
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        void StartMusic()
        {
            AudioManager.PlayBackMusic(Properties.Resources.MainMenuMusic, "MainMenuMusic.wav");
        }
    }
}
