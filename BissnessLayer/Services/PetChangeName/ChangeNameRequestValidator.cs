using FluentValidation;

namespace BissnessLayer.Services.PetChangeName;

public class ChangeNameRequestValidator : AbstractValidator<ChangeNameRequest>
{
    public ChangeNameRequestValidator()
    {
        RuleFor(x => x.PetId)
            .NotEmpty();

        RuleFor(x => x.NewName)
            .NotEmpty()
            .MaximumLength(50);
    }
}
