using System.Text.Json.Serialization;

namespace TanksAPI
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleType { get; set; } = "SPG";
        [JsonIgnore]
        public User User { get; set; }
        public int userId { get; set; }
        public Weapon Weapon { get; set; }
        public List<Equipment> Equipments { get; set; }
    }
}
