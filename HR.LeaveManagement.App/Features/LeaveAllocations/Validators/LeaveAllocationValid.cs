using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Validators
{
    public class LeaveAllocationValid : AbstractValidator<ILeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public LeaveAllocationValid(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            RuleFor(p => p.NumberOfDays)
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be before {ComparisonValue}");
            RuleFor(p => p.Period)
                .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after {ComparisonValue}");
            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leaveTypeExists = await _leaveTypeRepository.Exists(id);

                    return leaveTypeExists;
                })
                .WithMessage("{PropertyName} does not exist.");
        }

    }
}
