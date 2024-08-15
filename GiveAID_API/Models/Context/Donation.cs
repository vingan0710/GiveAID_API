using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace GiveAID_API.Models.Context
{
    public class Donation
    {
        public int Id { get; set; }
        public int? Donate_money { get; set; }
        public DateTime? Donation_date { get; set; }
        public string? Description { get; set; }
        public string? Trade_code { get; set; }
        public int? Id_account { get; set; }
        public int? Id_program { get; set; }

        public virtual Account? Id_accountNavigation { get; set; }
        public virtual Organization_program? Id_programtNavigation { get; set; }
    }
}
