using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviation.Models
{
    public class Donation
    {
        public int Id { get; set; }

        [Required]
        public string DonorName { get; set; } = string.Empty;

        [Required]
        public string ResourceType { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateDonated { get; set; } = DateTime.UtcNow;
    }
}

