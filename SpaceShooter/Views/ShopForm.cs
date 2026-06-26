using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter.Views
{
    public partial class ShopForm : Form1
    {
        List<SpaceShipData> spaceShips;
        int currentIndexShip = 0;
        public ShopForm()
        {
            InitializeComponent();

            spaceShips = new List<SpaceShipData>
            {
                new SpaceShipData { Name = "Fantasy SpaceShip", Image = Properties.Resources.spaceShip1_2, Price = 0, Speed = 60, IsOwned = true },
                new SpaceShipData { Name = "Shahed drone", Image = Properties.Resources.spaceShip4_2, Price = 700, Speed = 70, IsOwned = false},
                new SpaceShipData { Name = "Iranian Missile", Image = Properties.Resources.spaceShip3_2, Price = 1700, Speed = 90 },
                new SpaceShipData { Name = "Russian SuKhoi su-57", Image = Properties.Resources.spaceShip5_2, Price = 2000, Speed = 95, IsOwned = false },
                new SpaceShipData { Name = "American F-35", Image = Properties.Resources.spaceShip2_2, Price = 2500, Speed = 100, IsOwned = false }
            };
        }

        public void UpdateShop()
        {
            SpaceShipData spaceShip = spaceShips[currentIndexShip];


            if (spaceShip.IsOwned)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class SpaceShipData
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }

        public bool IsOwned { get; set; }
    }
}
