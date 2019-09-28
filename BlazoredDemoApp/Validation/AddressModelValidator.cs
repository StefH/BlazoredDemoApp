using BlazoredDemoApp.Models;
using FluentValidation;

namespace BlazoredDemoApp.Validation
{
    public class AddressModelValidator : AbstractValidator<AddressModel>
    {
        public AddressModelValidator()
        {
            RuleFor(p => p.Street).NotEmpty().WithMessage("Straat is verplicht");
        }
    }
}