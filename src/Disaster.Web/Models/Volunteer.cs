using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviation.Models
{
    public class Volunteer
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Skills { get; set; } = string.Empty;
    }
}

