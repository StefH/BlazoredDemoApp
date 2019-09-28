using System.ComponentModel.DataAnnotations;

namespace BlazoredDemoApp.Models
{
    public class ExampleModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required]
        public AddressModel Address { get; set; }
    }
}