using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GiveAID_API.Models.Context
{
    public partial class Account
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Avt {  get; set; }
        public string? Name {  get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public bool Type_acc { get; set; }
        public int Follower { get; set; }
        public int Like { get; set; }
        public int Support { get; set; }
        public DateTime? Created_at { get; set; }

        public virtual ICollection<Organization_program> Organization_Programs { get; } = new List<Organization_program>();
        public virtual ICollection<Donation> Donations { get; } = new List<Donation>();
        public virtual ICollection<Gallery> Galleries { get; } = new List<Gallery>();
    }

}
