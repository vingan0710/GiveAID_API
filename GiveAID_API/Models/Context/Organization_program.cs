using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GiveAID_API.Models.Context
{
    public partial class Organization_program
    {
        public int Id { get; set; }
        public string? O_name { get; set; }
        public string? O_description { get; set; }
        public string? O_image {  get; set; }
        public string? O_address { get; set; }
        public DateTime? Day_start { get; set; }
        public DateTime? Day_end { get; set; }
        public decimal? Target { get; set; }
        public decimal? Current { get; set; }
        public int? Status { get; set; }
        public bool Outstanding { get; set; }
        public int? Topic_id { get; set; }
        public int? Id_account { get; set; }

        public virtual Topic? Topic_idNavigation { get; set; }

        public virtual Account? Id_accounttNavigation { get; set; }

        public virtual ICollection<Donation> Donations { get; } = new List<Donation>();
        public virtual ICollection<Gallery> Galleries { get; } = new List<Gallery>();
    }
}
