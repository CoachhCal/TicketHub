namespace TicketHub
{
    public class Customer
    {

        public int ConcertID { get; set; } = 0;
        public required string Email { get; set; } = string.Empty;
        public required string Name { get; set; } = string.Empty;
        public required string Phone { get; set; } = string.Empty;
        public required int  Quantity { get; set; } = 0;
        public required string CreditCard { get; set; } = string.Empty;
        public required string Expiration { get; set; } = string.Empty;
        public required string SecurityCode { get; set; } = string.Empty;
        public required string Address { get; set; } = string.Empty;
        public required string City { get; set; } = string.Empty;
        public required string Province { get; set; } = string.Empty;
        public required string PostalCode { get; set; } = string.Empty;
        public required string Country { get; set; } = string.Empty;

    }
}
