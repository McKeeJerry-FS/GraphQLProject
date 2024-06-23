namespace GraphQLProject.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int PartySize { get; set; }
        public string SpecialRequest { get; set; } = string.Empty;
        public DateTime ReservationDate { get; set; }
    }
}
