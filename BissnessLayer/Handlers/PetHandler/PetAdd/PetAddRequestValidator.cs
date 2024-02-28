using FluentValidation;

namespace BissnessLayer.Handlers.PetHandler.PetAdd;

public class PetAddRequestValidator : AbstractValidator<PetAddRequest>
{
    public PetAddRequestValidator()
    {
        RuleFor(x => x.AnimalClass)
            .NotEmpty();

        RuleFor(x => x.MedicalStatus)
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);
    }
}
