using SpaceShooter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter.Views
{
    public partial class ShopForm : Form1
    {
        public List<SpaceShipData> spaceShips;
        private DatabaseConnection _Db;
        private GameStatsRepository _gameStats;
        private ShopItemsRepository _shopItems;
        private BuyManager _buyManager;


        int currentIndexShip = 0;
        int coins;
        public ShopForm()
        {
            InitializeComponent();

            _Db = new DatabaseConnection();
            _gameStats = new GameStatsRepository(_Db);
            _shopItems = new ShopItemsRepository(_Db);
            _buyManager = new BuyManager();

            coins = _gameStats.GetTotalCoins();


            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;

            int width = Properties.Resources.background2.Width + 50;
            int height = Properties.Resources.background2.Height + 200;
            ClientSize = new Size(width, height);

            BackgroundImage = Properties.Resources.backgroundShop1;
            BackgroundImageLayout = ImageLayout.Stretch;

            spaceShips = new List<SpaceShipData>
            {
                new SpaceShipData { Name = "Fantasy SpaceShip", Image = Properties.Resources.spaceShip1_2, Price = 0, Speed = 60, Damage = 50, IsOwned = true },
                new SpaceShipData { Name = "Shahed drone", Image = Properties.Resources.spaceShip4_2, Price = 700, Speed = 60, Damage = 70, IsOwned = false},
                new SpaceShipData { Name = "Russian SuKhoi-57", Image = Properties.Resources.spaceShip5_2, Price = 1700, Speed = 85,Damage = 75, IsOwned = false },
                new SpaceShipData { Name = "American F-35", Image = Properties.Resources.spaceShip2_2, Price = 2000, Speed = 90, Damage = 80, IsOwned = false },
                new SpaceShipData { Name = "Iranian Missile", Image = Properties.Resources.spaceShip3_2, Price = 2500, Speed = 90, Damage = 100, IsOwned = false }
            };

            LoadStateFromDb();

            UpdateShop();
            StartMusic();
            FormClosing += CloseShopMusic;
        }


        private void LoadStateFromDb()
        {
            for (int i = 0; i < spaceShips.Count; i++)
            {
                var ship = _shopItems.GetShipById(i + 1);
                if (ship != null)
                    spaceShips[i].IsOwned = ship.IsPurchased;
            }

            int equippedId = _shopItems.GetEquippedId();
            if (equippedId > 0)
                SpaceShipData.EquipedShipIndex = equippedId - 1;
        }

        public void UpdateShop()
        {
            SpaceShipData spaceShip = spaceShips[currentIndexShip];

            pictureShip.Image = spaceShip.Image;
            nameLabel.Text = spaceShip.Name;
            progressBarSpeed.Value = spaceShip.Speed;
            progressBarDamage.Value = spaceShip.Damage;

            amountLabel.Text = $"{coins}";

            if (spaceShip.IsOwned && currentIndexShip == SpaceShipData.EquipedShipIndex)
            {
                nameLabel.Text = $"★ {spaceShip.Name} ★";
                buyOrSelectButton.Text = "CURRENTLY EQUIPPED";
                buyOrSelectButton.ForeColor = Color.Gold;
            }
            else if (spaceShip.IsOwned)
            {
                buyOrSelectButton.Text = "EQUIP SHIP";
                buyOrSelectButton.ForeColor = Color.Green;
            }
            else
            {
                buyOrSelectButton.Text = $"BUY - {spaceShip.Price}";
                buyOrSelectButton.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.click);

            currentIndexShip = ((currentIndexShip + 1) % spaceShips.Count);
            UpdateShop();
        }


        private void PreviosButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.click);

            currentIndexShip--;
            if (currentIndexShip < 0)
            {
                currentIndexShip = spaceShips.Count - 1;
            }
            UpdateShop();
        }

        private void buyOrSelectButton_Click(object sender, EventArgs e)
        {
            SpaceShipData spaceShip = spaceShips[currentIndexShip];
            if (!spaceShip.IsOwned)
            {
                if (_buyManager.Buy(currentIndexShip + 1, coins))
                {
                    AudioManager.CoinPlayer(Properties.Resources.CoinMusic, "coinMusic.wav");
                    spaceShip.IsOwned = true;

                    coins = _gameStats.GetTotalCoins();

                    UpdateShop();
                    MessageBox.Show($"Buy spaceShip {spaceShip.Name} was succusfully! ");
                }
                else
                {
                    AudioManager.PlaySfx(Properties.Resources.error1);
                    MessageBox.Show($"You don't have enough coin! ");
                }
            }
            else
            {

                if (currentIndexShip == SpaceShipData.EquipedShipIndex)
                {
                    AudioManager.PlaySfx(Properties.Resources.errorShop);
                    MessageBox.Show($"{spaceShip.Name} had been equipped! ");
                }
                else
                {
                    AudioManager.PlaySfx(Properties.Resources.equipedClick);
                    MessageBox.Show($"Equip spaceShip {spaceShip.Name} was succusfully! ");
                    SpaceShipData.EquipedShipIndex = currentIndexShip;
                    _shopItems.SetEquipped(currentIndexShip + 1);
                }

                UpdateShop();
            }
        }

        void StartMusic()
        {
            AudioManager.PlayBackMusic(Properties.Resources.Shop, "ShopMusic.wav");
        }

        void CloseShopMusic(Object sender, FormClosingEventArgs e)
        {
            AudioManager.StopBackMusic();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AudioManager.PlaySfx(Properties.Resources.click);
            Close();
        }

        private void pictureShip_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
    public class SpaceShipData
    {
        static public int EquipedShipIndex { get; set; } = 0;
        public string Name { get; set; }
        public Image Image { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Damage { get; set; }
        public bool IsOwned { get; set; }
    }
}
    
