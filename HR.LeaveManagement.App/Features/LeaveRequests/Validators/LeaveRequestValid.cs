using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using System;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Validators
{
    public class LeaveRequestValid : AbstractValidator<ILeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public LeaveRequestValid(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            RuleFor(p => p.StartDate)
                .LessThan(p => p.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");
            RuleFor(p => p.EndDate)
                .GreaterThan(p => p.StartDate)
                .WithMessage("{PropertyName} must be after {ComparisonValue}");
            RuleFor(p => p.LeaveTypeId).GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                    return !leaveTypeExists;
                })
                .WithMessage("{PropertyName} does not exist.");
        }

    }
}
