using HR.LeaveManagement.App.Data.DTOs;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public IUpdateLeaveAllocationDto LeaveAllocationDto { get; set; }

    }
}
