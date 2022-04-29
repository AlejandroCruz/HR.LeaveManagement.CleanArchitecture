using HR.LeaveManagement.App.Data.DTOs;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
