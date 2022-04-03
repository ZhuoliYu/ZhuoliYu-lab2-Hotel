namespace Lab1_DataAnnotations_Hotel.Models
{
    public class CurrentlyBooking
    {
        public int Id { get; set; }
        public int CurrentClientId { get; set; }
        public Client CurrentClient { get; set; }




        public string CurrentRoomNumber { get; set; }
        public Room CurrentRoom { get; set; }
    }
   
}
