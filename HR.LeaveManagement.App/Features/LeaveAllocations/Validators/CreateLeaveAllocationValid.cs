﻿using FluentValidation;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Validators
{
    public class CreateLeaveAllocationValid : AbstractValidator<ICreateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveAllocationValid(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new LeaveAllocationValid(_leaveTypeRepository));
        }

    }
}
