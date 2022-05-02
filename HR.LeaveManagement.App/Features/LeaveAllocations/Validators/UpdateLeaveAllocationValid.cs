using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Validators
{
    public class UpdateLeaveAllocationValid : AbstractValidator<IUpdateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveAllocationValid(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new LeaveAllocationValid(_leaveTypeRepository));

            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName} must be present.");
        }
    }
}
