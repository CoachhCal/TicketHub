using System.ComponentModel.DataAnnotations;

namespace TicketHub
{
    public class Customer
    {
        [Required(ErrorMessage = "ConcertID is required")]
        public int ConcertID { get; set; } = 0;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required")]
        public int  Quantity { get; set; } = 0;

        [Required(ErrorMessage = "Credit Card is required")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Credit Card must be exactly 16 digits")]
        public string CreditCard { get; set; } = string.Empty;

        [Required(ErrorMessage = "Expiration date is required")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Expiration date must be in the format mm/yy")]
        public string Expiration { get; set; } = string.Empty;

        [Required(ErrorMessage = "Security code is required")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Credit Card must be exactly 16 digits")]
        public string SecurityCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "City can only contain letters and spaces")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Province is required")]
        [RegularExpression(@"^(Ontario|Quebec|Nova Scotia|New Brunswick|Manitoba|British Columbia|Prince Edward Island|Saskatchewan|Alberta|Newfoundland and Labrador|Northwest Territories|Yukon|Nunavut)$", ErrorMessage = "Invalid province name")]
        public string Province { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required")]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z][ ]?\d[A-Za-z]\d$", ErrorMessage = "Invalid postal code format")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Country can only contain letters and spaces")]
        public string Country { get; set; } = string.Empty;

    }
}
