using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceShooter.Views
{
    public partial class BulletShopForm : Form
    {
        public BulletShopForm()
        {
            InitializeComponent();
        }
        public void Buy()
        {

        }
        public void UodateShopUI()
        {
            
        }
    }
    public class BulletShopData
    {
        static public int EquipedBulletIndex { get; set; } = 0;
        public string Name { get; set; }
        public Image Image { get; set; }
        public int Price { get; set; }
        public bool IsOwned { get; set; }
    }
}
