namespace TanksAPI
{
    public class AddWeaponDto
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        public int VehicleId { get; set; }
    }
}
