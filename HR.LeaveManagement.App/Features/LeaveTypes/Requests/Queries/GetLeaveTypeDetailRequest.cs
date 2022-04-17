using HR.LeaveManagement.App.Data.DTOs;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
