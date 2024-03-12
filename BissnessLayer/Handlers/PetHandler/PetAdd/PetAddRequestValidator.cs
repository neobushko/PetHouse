using Core.Enums;
using FluentValidation;

namespace BissnessLayer.Handlers.PetHandler.PetAdd;

public class PetAddRequestValidator : AbstractValidator<PetAddRequest>
{
    public PetAddRequestValidator()
    {
        RuleFor(x => x.AnimalClass)
            .IsInEnum();

        RuleFor(x => x.MedicalStatus)
            .IsInEnum();

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);
    }
}
