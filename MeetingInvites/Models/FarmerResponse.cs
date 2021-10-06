using System.ComponentModel.DataAnnotations;

namespace MeetingInvites.Models
{
    public class FarmerResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
    }
}