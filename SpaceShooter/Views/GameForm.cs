using SpaceShooter.Core;
using SpaceShooter.Models;
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
        Image CoinImg = Properties.Resources.Coin;
        Image playerShooterImg = Properties.Resources.spaceShip1; 
        Image standardImg = Properties.Resources.estandardEnumy;
        Image zigzagImg = Properties.Resources.zigzagEnumy;
        Image shooterImg = Properties.Resources.shooter;
        Image entehariImg = Properties.Resources.entehari;
        Image giantImg = Properties.Resources.giant;
        Image destroyImage = Properties.Resources.boomb;

        System.Windows.Forms.Timer timer;


        private GameEngine _gameEngine;
        private InputState _inputState;

        public GameForm()
        {
            InitializeComponent();
            this.ActiveControl = null;


            if (ImageAnimator.CanAnimate(playerShooterImg)) ImageAnimator.Animate(playerShooterImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(standardImg)) ImageAnimator.Animate(standardImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(zigzagImg)) ImageAnimator.Animate(zigzagImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(shooterImg)) ImageAnimator.Animate(shooterImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(entehariImg)) ImageAnimator.Animate(entehariImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(giantImg)) ImageAnimator.Animate(giantImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(CoinImg)) ImageAnimator.Animate(CoinImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(destroyImage)) ImageAnimator.Animate(destroyImage, OnFrameChanged);


            pausePanel.Visible = false;

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;

            KeyPreview = true;
            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;

            int width = Properties.Resources.background2.Width + 50;
            int height = Properties.Resources.background2.Height + 200;
            ClientSize = new Size(width, height);



            RectangleF screenBounds = new RectangleF(0, 0, ClientSize.Width, ClientSize.Height);

            _gameEngine = new GameEngine(screenBounds);
            _inputState = new InputState();

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

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_gameEngine == null) return;

            _inputState.KeyDown(e.KeyCode);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (_gameEngine == null) return;

            _inputState.KeyUp(e.KeyCode);
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
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



                GameData.Score = _gameEngine.Session.Score;
                GameData.Coin = _gameEngine.Session.CoinsCollected;
                GameData.CurrentLevel = _gameEngine.Session.CurrentWave;
                GameData.Health = (int)Math.Ceiling((_gameEngine.Session.Player.Health / (float)GameRules.PlayerMaxHealth) * 12);


                UpdateUI();

                float deltatime = 0.020f;
          
                 _gameEngine.Update(deltatime, _inputState);

                if (_gameEngine.Session.Status == Enums.GameStatus.gameOver)
                {
                    timer.Stop();
                    AudioManager.StopBackMusic();
                    MessageBox.Show($"Game Over!\nScore: {_gameEngine.Session.Score}", " شما باختید");
                    Close();
                    return;
                }

                if(_gameEngine.Session.Status == Enums.GameStatus.gameOver)
                {
                    timer.Stop();
                    AudioManager.StopBackMusic();
                    MessageBox.Show($"Game Over!\nScore: {_gameEngine.Session.Score}", "پایان بازی");
                    Close();
                    return;
                }





                Invalidate();

            }

        }

        void GameFormPaint(Object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(backgroundGame, 0, y1, ClientSize.Width, ClientSize.Height);
            e.Graphics.DrawImage(backgroundGame, 0, y2, ClientSize.Width, ClientSize.Height);

            ImageAnimator.UpdateFrames();

            if (_gameEngine != null && _gameEngine.Session != null)
            {
                e.Graphics.DrawImage(playerShooterImg , _gameEngine.Session.Player.GetBounds());

                

                foreach (var enemy in _gameEngine.Session.ActiveEnemies)
                {
                    if (enemy is StandardEnemy st)
                        e.Graphics.DrawImage(standardImg, st.GetBounds());
                    else if (enemy is ScoutEnemy sc)
                        e.Graphics.DrawImage(zigzagImg, sc.GetBounds());
                    else if (enemy is ShooterEnemy sh)
                        e.Graphics.DrawImage(shooterImg, sh.GetBounds());
                    else if (enemy is TeroristEnemy ter)
                        e.Graphics.DrawImage(entehariImg, ter.GetBounds());
                    else if (enemy is HeavyTankEnemy heavy)
                        e.Graphics.DrawImage(giantImg, heavy.GetBounds());

                  
                }


                foreach (var bullet in _gameEngine.Session.ActiveBullets)
                {
                    if (bullet.IsPlayerBullet)
                    {
                        e.Graphics.DrawImage(Properties.Resources.shelik_gololeh_abi, bullet.GetBounds());
                    }
                    else
                    {
                        e.Graphics.DrawImage(Properties.Resources.Shelik_golooleh_enumy, bullet.GetBounds());
                    }
                }

                foreach (var coin in _gameEngine.Session.ActiveCoins)
                {
                    e.Graphics.DrawImage(CoinImg  , coin.GetBounds());
                }


            }
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
            this.ActiveControl = null;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!pausePanel.Visible)
            {
                switch (keyData)
                {
                    case Keys.Space:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Left:
                    case Keys.Right:
                        OnKeyDown(new KeyEventArgs(keyData));
                        return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
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

