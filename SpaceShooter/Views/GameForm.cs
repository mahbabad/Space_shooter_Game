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
    public partial class GameForm : Form1
    {
        int y1, y2;
        int scrollSpeed = 4;
        Image backgroundGame = Properties.Resources.background1;

        System.Windows.Forms.Timer timer;

        public GameForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;

            int width = Properties.Resources.background2.Width + 50;
            int height = Properties.Resources.background2.Height + 200;
            ClientSize = new Size(width, height);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += GameLoop;
            timer.Start();

            y1 = 0;
            y2 = -ClientSize.Height;

            Paint += GameFormPaint;

            StartMusic();
            FormClosing += GameFormClosing;
        }

        void GameLoop(Object sender, EventArgs e)
        {
            y1 += scrollSpeed;
            y2 += scrollSpeed;

            if (y1 >= ClientSize.Height)
            {
                y1 = y2 - ClientSize.Height;
            }

            if (y2 >= ClientSize.Height)
            {
                y2 = y1 - ClientSize.Height;
            }
            Update();

            Invalidate();
        }

        void GameFormPaint(Object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(backgroundGame, 0, y1, ClientSize.Width, ClientSize.Height);
            e.Graphics.DrawImage(backgroundGame, 0, y2, ClientSize.Width, ClientSize.Height);
        }

        void StartMusic()
        {
            AudioManager.PlayBackMusic(Properties.Resources.GameMusic, "GameMusic.wav");
        }

        void GameFormClosing(Object sender, FormClosingEventArgs e)
        {
            AudioManager.StopBackMusic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        void Update()
        {
            coinLabel.Text = $"🪙Coin: {GameData.Coin}";
            scoreLabel.Text = $"🏆Score: {GameData.Score}";
            waveLabel.Text = $"Wave: {GameData.CurrentLevel}/10";

            if (GameData.Health >= 1)
            {
                pictureHeart1.Visible = true;
                if (GameData.Health >= 2)
                {
                    pictureHeart2.Visible = true;
                    if(GameData.Health >= 3)
                    {
                        pictureHeart3.Visible = true;
                        if (GameData.Health >= 4)
                        {
                            pictureHeart4.Visible = true;
                        }
                    }
                }
            }
        }
    }
    public static class GameData
    {
        public static int Coin = 0;
        public static int Score = 0;
        public static int Health = 3;
        public static int CurrentLevel = 1;
    }
}

