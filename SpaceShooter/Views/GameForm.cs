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
            pausePanel.BackColor = Color.FromArgb(150, 0, 0, 0);
            pausePanel.Visible = false;

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
            if (!pausePanel.Visible)
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
                UpdateUI();

                Invalidate();

            }

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



        void UpdateUI()
        {
            coinLabel.Text = $"🪙Coin: {GameData.Coin}";
            scoreLabel.Text = $"🏆Score: {GameData.Score}";
            waveLabel.Text = $"Wave: {GameData.CurrentLevel}/10";


            if (GameData.Health == 0)
            {
                pictureHeart1.Visible = false;
                pictureHeart2.Visible = false;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 1)
            {
                pictureHeart1.Image = Properties.Resources._1sevvom_Heart;
                pictureHeart2.Visible = false;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 2)
            {
                pictureHeart1.Image = Properties.Resources._2sevvom_heart;
                pictureHeart2.Visible = false;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 3)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Visible = false;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 4)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources._1sevvom_Heart;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 5)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources._2sevvom_heart;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 6)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Visible = false;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 7)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources._1sevvom_Heart;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 8)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources._2sevvom_heart;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 9)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Visible = false;
            }
            else if (GameData.Health == 10)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Image = Properties.Resources._1sevvom_Heart;
            }
            else if (GameData.Health == 11)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Image = Properties.Resources._2sevvom_heart;
            }
            else if (GameData.Health == 12)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Image = Properties.Resources.Full_Heart;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pausePanel.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            pausePanel.Visible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

    }
    public static class GameData
    {
        public static int Coin = 0;
        public static int Score = 0;
        public static int Health = 12;
        public static int CurrentLevel = 1;
    }
}

