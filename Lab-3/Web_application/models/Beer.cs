using System.ComponentModel.DataAnnotations;

namespace Web_application.models
{
    public class Beer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Voltage { get; set; }
        public float Volume { get; set; }
        public float Price { get; set; }
        [DataType(DataType.Date)]

        public DateTime Deadline { get; set; }

    }
}
