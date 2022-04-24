using System.Text.Json.Serialization;

namespace TanksAPI
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }

    }
}
