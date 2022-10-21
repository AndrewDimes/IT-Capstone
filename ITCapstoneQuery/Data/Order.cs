namespace ITCapstoneQuery.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public float subTotal { get; set; }
        public float tax { get; set; }
        public float shipping { get; set; }
        public float total { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? line1 { get; set; }
        public string? line2 { get; set; }
        public string? city { get; set; }
        public string? province { get; set; }
        public string? country { get; set; }
        public DateTime createdAt { get; set; }
    }
}
