using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using System;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Validators
{
    public class CreateLeaveRequestValid : AbstractValidator<ICreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestValid(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new LeaveRequestValid(_leaveTypeRepository));
        }
    }
}
