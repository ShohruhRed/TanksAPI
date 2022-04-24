namespace TanksAPI
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VehicleType { get; set; } = "SPG";
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
