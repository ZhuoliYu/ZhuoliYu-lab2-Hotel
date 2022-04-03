using Lab1_DataAnnotations_Hotel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_DataAnnotations_Hotel.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(10)")]

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Sorry, minimum is 3 and maximum is 25 characters")]
        public string? FirstName { get; set; }
        [Column(TypeName = "varchar(10)")]

        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Sorry, minimum is 3 and maximum is 25 characters")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Phone Number is incorrect")]
        public string PhoneNumber { get; set; }


        [InverseProperty("CurrentClient")]
        public ICollection<CurrentlyBooking> CurrentlyBooking { get; set; }
        [InverseProperty("PreviousClient")]
        public ICollection<PreviouslyBooking> PreviouslyBooking { get; set; }
        [InverseProperty("Client")]
        public ICollection<Credit> Credits { get; set; }

        public Client()
        {
            CurrentlyBooking = new HashSet<CurrentlyBooking>();
            PreviouslyBooking = new HashSet<PreviouslyBooking>();

            Credits = new HashSet<Credit>();
        }
    }
}
