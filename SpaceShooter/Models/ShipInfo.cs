namespace SpaceShooter.Models
{
    public class ShipInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Speed { get; set; }
        public int MaxHealth { get; set; }
        public int Price { get; set; }
        public bool IsPurchased { get; set; }
        public bool IsActive { get; set; }
    }
}
