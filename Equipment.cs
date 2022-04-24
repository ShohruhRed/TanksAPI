using System.Text.Json.Serialization;

namespace TanksAPI
{
    public class Equipment
    {
        public int Id { get; set; }
        public string EquipmentName { get; set; }
        public int Increase { get; set; }
        [JsonIgnore]
        public List<Vehicle> Vehicles { get; set; }
    }
}
