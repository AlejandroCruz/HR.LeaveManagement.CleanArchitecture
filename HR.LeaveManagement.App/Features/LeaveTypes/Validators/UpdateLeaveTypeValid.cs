using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using System;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Validators
{
    public class UpdateLeaveTypeValid : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeValid()
        {
            Include(new LeaveTypeValid());

            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
