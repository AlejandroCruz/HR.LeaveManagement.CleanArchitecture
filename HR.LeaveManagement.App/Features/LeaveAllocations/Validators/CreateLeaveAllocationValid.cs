using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Validators
{
    public class CreateLeaveAllocationValid : AbstractValidator<ICreateLeaveAllocationDto>
    {
        public CreateLeaveAllocationValid()
        {
            RuleFor(p => p.NumberOfDays)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
                .LessThan(100).WithMessage("{PropertyName} must be less than 100.");

            RuleFor(p => p.LeaveTypeId)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.Period)
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }

    }
}
