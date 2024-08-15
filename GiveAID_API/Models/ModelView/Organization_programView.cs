namespace GiveAID_API.Models.ModelView
{
    public class Organization_programView
    {
        public int Id { get; set; }
        public string? O_name { get; set; }
        public string? O_description { get; set; }
        public string? O_image { get; set; }
        public string? O_address { get; set; }
        public DateTime? Day_start { get; set; }
        public DateTime? Day_end { get; set; }
        public decimal? Target { get; set; }
        public decimal? Current { get; set; }
        public int? Status { get; set; }
        public bool Outstanding { get; set; }
        public int? Topic_id { get; set; }
        public string? Topic_name { get; set; }
        public int? Id_account { get; set; }
        public string? Username { get; set; }
        public string? Avt { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
    }
}
