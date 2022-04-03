using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_DataAnnotations_Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }
       
        [Key]
        public string RoomNumber { get; set; }

        public int capacity { get; set; }

        public Section Section { get; set; }

        [ForeignKey("CurrentRoomNumber")]
        [InverseProperty("CurrentRoom")]
        public ICollection<CurrentlyBooking> CurrentlyBooking { get; set; }
        [ForeignKey("PreviousRoomNumber")]
        [InverseProperty("PreviousRoom")]
        public ICollection<PreviouslyBooking> PreviouslyBooking { get; set; }
        public Room()
        {
            CurrentlyBooking = new HashSet<CurrentlyBooking>();
            PreviouslyBooking = new HashSet<PreviouslyBooking>();
        }
    }

    public enum Section
    {
        [Display(Name = "1st")]
        First,
        [Display(Name = "2nd")]
        Second,
        [Display(Name = "3rd")]
        Third
    }
}
