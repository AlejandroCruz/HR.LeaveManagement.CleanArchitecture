using HR.LeaveManagement.App.Data.DTOs;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
