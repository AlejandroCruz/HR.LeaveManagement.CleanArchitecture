using HR.LeaveManagement.App.Data.DTOs;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<ILeaveRequestListDto>>
    {
    }
}
