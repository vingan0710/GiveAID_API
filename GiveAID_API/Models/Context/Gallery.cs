namespace GiveAID_API.Models.Context
{
    public class Gallery
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? G_description {  get; set; } 
        public DateTime? Created_at { get; set; }
        public int? Program_id { get; set; }
        public int? Account_id { get; set; }

        public virtual Organization_program? Program_idNavigation { get; set; }
        public virtual Account? Account_idNavigation { get; set; }
    }
}
