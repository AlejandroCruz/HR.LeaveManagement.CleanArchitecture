using HR.LeaveManagement.App.Data.DTOs;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        public Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
