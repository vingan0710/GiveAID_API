namespace GiveAID_API.Models.Context
{
    public partial class Topic
    {
        public int Id { get; set; }
        public string? Topic_name { get; set; }

        public virtual ICollection<Organization_program> Organization_Programs { get; } = new List<Organization_program>();
    }
}
