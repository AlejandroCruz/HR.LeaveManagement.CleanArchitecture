using HR.LeaveManagement.App.Data.DTOs;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
