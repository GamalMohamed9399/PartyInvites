using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please Enter your Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Email Address")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please Specify You Wil Attend")]
        public bool? WillAttend { get; set; }
    }
}
