using BlazoredDemoApp.Models;
using FluentValidation;

namespace BlazoredDemoApp.Validation
{
    public class ExampleModelValidator : AbstractValidator<ExampleModel>
    {
        public ExampleModelValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Moet naam invullen");

            RuleFor(model => model.Address).SetValidator(new AddressModelValidator());
        }
    }
}