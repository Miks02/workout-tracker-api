using FluentValidation;
using WorkoutTrackerApi.DTO.Auth;

namespace WorkoutTrackerApi.Validators;

public class LoginValidator : AbstractValidator<LoginRequestDto>
{

    public LoginValidator()
    {
        RuleFor(l => l.Email)
            .NotEmpty()
            .WithMessage("Email is required");

        RuleFor(l => l.Password)
            .NotEmpty()
            .WithMessage("Password is required");
    }
    
}