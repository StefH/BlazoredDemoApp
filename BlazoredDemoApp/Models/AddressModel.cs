using System.ComponentModel.DataAnnotations;

namespace BlazoredDemoApp.Models
{
    public class AddressModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Street is too long.")]
        public string Street { get; set; }
    }
}
