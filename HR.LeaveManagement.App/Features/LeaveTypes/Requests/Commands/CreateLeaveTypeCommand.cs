using HR.LeaveManagement.App.Data.DTOs;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
