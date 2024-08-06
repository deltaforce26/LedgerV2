using System.Text.Json.Serialization;

namespace LedgerV2.Model
{
    public class Ledger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<User>? Users { get; set; } = new List<User>();
    }
}
