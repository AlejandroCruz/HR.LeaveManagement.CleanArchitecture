using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using System;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Validators
{
    public class LeaveTypeValid : AbstractValidator<ILeaveTypeDto>
    {
        public LeaveTypeValid()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not excede {ComparisonValue} characters.");

            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
                .LessThan(100).WithMessage("{PropertyName} must be less than {ComparisonValue}.");
        }
    }
}
