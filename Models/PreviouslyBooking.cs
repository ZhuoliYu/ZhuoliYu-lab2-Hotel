namespace Lab1_DataAnnotations_Hotel.Models
{
    public class PreviouslyBooking
    {
        public int Id { get; set; }
        public int PreviousClientId { get; set; }
        public Client PreviousClient { get; set; }

        public string PreviousRoomNumber { get; set; }
        public Room PreviousRoom { get; set; }
    }
}
