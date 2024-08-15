using GiveAID_API.Models.Context;

namespace GiveAID_API.Models.ModelView
{
    public class AccountView
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Avt { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public bool Type_acc { get; set; }
        public int Follower { get; set; }
        public int Like { get; set; }
        public int Support { get; set; }
        public DateTime? Created_at { get; set; }
        public List<Organization_programView>? lsOrg { get; set; }
        public List<GalleryView>? lsGal { get; set; }


    }
}
