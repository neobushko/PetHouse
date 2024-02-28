using FluentValidation;

namespace BissnessLayer.Handlers.PetHandler.PetChangeName;

public class PetChangeNameRequestValidator : AbstractValidator<PetChangeNameRequest>
{
    public PetChangeNameRequestValidator()
    {
        RuleFor(x => x.PetId)
            .NotEmpty();

        RuleFor(x => x.NewName)
            .NotEmpty()
            .MaximumLength(50);
    }
}
