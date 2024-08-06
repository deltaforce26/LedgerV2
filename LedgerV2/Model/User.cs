using System.Text.Json.Serialization;

namespace LedgerV2.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [JsonIgnore]
        public ICollection<Ledger>? Ledgers { get;  set; }
    }
}
