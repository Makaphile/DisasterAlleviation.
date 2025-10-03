using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviation.Models
{
    public class Incident
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateReported { get; set; } = DateTime.UtcNow;
    }
}

