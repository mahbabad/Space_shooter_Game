using SpaceShooter.Core;
using SpaceShooter.Data;
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
        Image CoinSilverImg = Properties.Resources.silverCoin;
        Image playerShooterImg = Properties.Resources.spaceShip1;
        Image standardImg = Properties.Resources.estandardEnumy;
        Image zigzagImg = Properties.Resources.zigzagEnumy;
        Image shooterImg = Properties.Resources.shooter;
        Image entehariImg = Properties.Resources.entehari;
        Image giantImg = Properties.Resources.giant;
        Image destroyImage = Properties.Resources.boomb;
        Image PlayerShahed = Properties.Resources.spaceShip4;
        Image PLayerF35 = Properties.Resources.spaceShip2;
        Image PLayerIranianm = Properties.Resources.spaceship3;
        Image PlayerSokho = Properties.Resources.spaceShip5;
        Image Shield = Properties.Resources.Shield;
        Image Hale = Properties.Resources.HaleShield;
        Image _playerImg;



        System.Windows.Forms.Timer timer;


        private GameEngine _gameEngine;
        private InputState _inputState;
        private DatabaseConnection _databaseConnection;
        private ShopItemsRepository _shopItemsRepository;
        private GameStatsRepository _gamestats;

        public GameForm()
        {
            InitializeComponent();
            this.ActiveControl = null;

            GameData.Coin = 0;
            GameData.Score = 0;
                GameData.Health = 9;
            GameData.CurrentLevel = 1;

           

            if (ImageAnimator.CanAnimate(playerShooterImg)) ImageAnimator.Animate(playerShooterImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(standardImg)) ImageAnimator.Animate(standardImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(zigzagImg)) ImageAnimator.Animate(zigzagImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(shooterImg)) ImageAnimator.Animate(shooterImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(entehariImg)) ImageAnimator.Animate(entehariImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(giantImg)) ImageAnimator.Animate(giantImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(CoinImg)) ImageAnimator.Animate(CoinImg, OnFrameChanged);
            if (ImageAnimator.CanAnimate(destroyImage)) ImageAnimator.Animate(destroyImage, OnFrameChanged);
            if (ImageAnimator.CanAnimate(PLayerF35)) ImageAnimator.Animate(PLayerF35, OnFrameChanged);
            if (ImageAnimator.CanAnimate(PlayerSokho)) ImageAnimator.Animate(PlayerSokho, OnFrameChanged);
            if (ImageAnimator.CanAnimate(PLayerIranianm)) ImageAnimator.Animate(PLayerIranianm, OnFrameChanged);
            if (ImageAnimator.CanAnimate(PlayerShahed)) ImageAnimator.Animate(PlayerShahed, OnFrameChanged);
            if(ImageAnimator.CanAnimate(CoinSilverImg)) ImageAnimator.Animate(CoinSilverImg , OnFrameChanged);
            if (ImageAnimator.CanAnimate(Shield))
            {
                ImageAnimator.Animate(Shield, OnFrameChanged);
            }
            if (ImageAnimator.CanAnimate(Hale))
            {
                ImageAnimator.Animate(Hale, OnFrameChanged);
            }
            pictureHeart4.Visible = false;

            pausePanel.Visible = false;
            FirstPanel.Visible = true;
            EndPanel.Visible = false;
            LostPanel.Visible = false;
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
            _databaseConnection = new DatabaseConnection();
            _shopItemsRepository = new ShopItemsRepository(_databaseConnection);
            _gamestats = new GameStatsRepository(_databaseConnection);



            _playerImg = GetEquippedShipImage();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += GameLoop;
            timer.Start();


            y1 = 0;
            y2 = -ClientSize.Height;

            Paint += GameFormPaint;

            StartMusic();
            FormClosing += GameFormClosing;

            UpdateUI();
        }

        private Image GetEquippedShipImage()
        {
            switch (_shopItemsRepository.GetEquippedId() - 1)
            {
                case 0: return playerShooterImg;
                case 1: return PlayerShahed;
                case 2: return PlayerSokho;
                case 3: return PLayerF35;
                case 4: return PLayerIranianm;
                default: return playerShooterImg;
            }
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
            if (!pausePanel.Visible && !EndPanel.Visible && !FirstPanel.Visible && !LostPanel.Visible)
            {

                waveLabel.Visible = true;

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
                GameData.Health = _gameEngine.Session.Player.Health;


                UpdateUI();

                float deltatime = 0.020f;

                _gameEngine.Update(deltatime, _inputState);

                if (_gameEngine.Session.Status == Enums.GameStatus.gameOver)
                {
                    timer.Stop();
                    label8.Text = _gamestats.GetHighScore().ToString();
                    label4.Text = GameData.Score.ToString();
                    label6.Text = GameData.Coin.ToString();
                    AudioManager.StopBackMusic();
                    AudioManager.PlayBackMusic(Properties.Resources.gameover, "gameOver.wav");
                    LostPanel.Visible = true;
                    return;
                }

                if (_gameEngine.Session.Status == Enums.GameStatus.finish)
                {
                    timer.Stop();
                    labelscore.Text = GameData.Score.ToString();
                    HighAmountScoreabel.Text = _gamestats.GetHighScore().ToString();
                    coinAmoutLabel.Text = GameData.Coin.ToString();
                    AudioManager.StopBackMusic();
                    AudioManager.PlayBackMusic(Properties.Resources.win, "win.wav");
                    EndPanel.Visible = true;
                    return;
                }


                Invalidate();

            }
            else if (EndPanel.Visible || FirstPanel.Visible || LostPanel.Visible)
            {
                waveLabel.Visible = false;
            }

        }

        void GameFormPaint(Object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(backgroundGame, 0, y1, ClientSize.Width, ClientSize.Height);
            e.Graphics.DrawImage(backgroundGame, 0, y2, ClientSize.Width, ClientSize.Height);

            ImageAnimator.UpdateFrames();

            if (_gameEngine != null && _gameEngine.Session != null)
            {
                e.Graphics.DrawImage(_playerImg, _gameEngine.Session.Player.GetBounds());
                if (_gameEngine.Session.Player.ShieldDuration > 0)
                {
                    float playerX = _gameEngine.Session.Player.Width;
                    float playerY = _gameEngine.Session.Player.Height;

                    float shieldScale = 1.2f;
                    float shieldWidth = playerX * shieldScale;
                    float shieldHeight = playerY * shieldScale;

                    float drawX = _gameEngine.Session.Player.X - ((shieldWidth - playerX) / 2);
                    float drawY = _gameEngine.Session.Player.Y - ((shieldHeight - playerY) / 2);
                    e.Graphics.DrawImage(Hale,drawX, drawY, shieldWidth, shieldHeight);
                }


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
                foreach(var fx in _gameEngine.Session.Effects)
                {
                    e.Graphics.DrawImage(destroyImage, fx.GetBounds());
                }

                foreach (var coin in _gameEngine.Session.ActiveCoins)
                {
                    if(coin.type == Enums.CoinType.Gold )
                    e.Graphics.DrawImage(CoinImg, coin.GetBounds());
                    else
                    e.Graphics.DrawImage(CoinSilverImg, coin .X , coin.Y , coin.Width-20f , coin.Height-20f);
                }

                foreach (var shield in _gameEngine.Session.ActiveShields)
                {
                    e.Graphics.DrawImage(Shield, shield.GetBounds());
                   
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

            pictureHeart1.Visible = true;
            pictureHeart2.Visible = true;
            pictureHeart3.Visible = true;
            pictureHeart4.Visible = false;


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
                pictureHeart4.Visible = true;
            }
            else if (GameData.Health == 11)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Image = Properties.Resources._2sevvom_heart;
                pictureHeart4.Visible = true;
            }
            else if (GameData.Health == 12)
            {
                pictureHeart1.Image = Properties.Resources.Full_Heart;
                pictureHeart2.Image = Properties.Resources.Full_Heart;
                pictureHeart3.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Image = Properties.Resources.Full_Heart;
                pictureHeart4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            pausePanel.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            pausePanel.Visible = false;
            this.ActiveControl = null;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void HighAmountScoreabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AudioManager.StopBackMusic();
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AudioManager.StopBackMusic();
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _gameEngine.Session.Player.Health = 12;
            GameData.Health = 12;
            FirstPanel.Visible = false;
            pictureHeart4.Visible = true;
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            UpdateUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _gameEngine.Session.Player.Health = 9;
            GameData.Health = 9;
            FirstPanel.Visible = false;
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            UpdateUI();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.gameClick);
            Hide();
            
            GameForm newGame = new GameForm();
            newGame.ShowIcon = false;
            newGame.ShowInTaskbar = false;
            DialogResult result = newGame.ShowDialog();
            if (result == DialogResult.Abort)
            {
                Application.Exit();
                return;
            }
            this.Close();
            

        }
    }
    public static class GameData
    {
        public static int Coin = 0;
        public static int Score = 0;
        public static int Health = 9;
        public static int CurrentLevel = 1;
    }
}

