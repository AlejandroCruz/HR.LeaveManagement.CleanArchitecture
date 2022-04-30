using HR.LeaveManagement.App.Data.DTOs;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
