using System.ComponentModel.DataAnnotations;

namespace Lab1_DataAnnotations_Hotel.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength =3, ErrorMessage = "Sorry, minimum is 3 and maximum is 25 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Sorry, minimum is 3 and maximum is 25 characters"")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Phone Number is incorrect")]
        public string PhoneNumber { get; set; }
    }
}
