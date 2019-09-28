using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazoredDemoApp.Validation
{
public class FluentValidationValidatorNew : ComponentBase
{
    [Inject] IServiceProvider ServiceProvider { get; set; }

    [CascadingParameter] public EditContext CurrentEditContext { get; set; }

    [Parameter] public IValidator Validator { get; set; }


    protected override void OnInitialized()
    {
        if (CurrentEditContext == null)
        {
            throw new InvalidOperationException($"{nameof(FluentValidationValidator)} requires a cascading " +
                                                $"parameter of type {nameof(EditContext)}. For example, you can use {nameof(FluentValidationValidator)} " +
                                                $"inside an {nameof(EditForm)}.");
        }

        CurrentEditContext.AddFluentValidation(ServiceProvider, Validator);
    }
}
}
