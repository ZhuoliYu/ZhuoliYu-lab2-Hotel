using System.ComponentModel.DataAnnotations;

namespace Lab1_DataAnnotations_Hotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        //PrimaryKey
        [Key]
        public string RoomNumber { get; set; }

        public int capacity { get; set; }

        public Section Section { get; set; }
    }

    public enum Section
    {
        [Display(Name = "First")]
        First,
        [Display(Name = "Second")]
        Second,
        [Display(Name = "Third")]
        Third
    }
}
