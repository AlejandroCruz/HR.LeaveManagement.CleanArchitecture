using AutoMapper;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Features.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<ILeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<List<ILeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            List<Domain.LeaveRequest> leaveRequests = await _leaveRequestRepository.GetLeaveRequestWithDetails();

            return _mapper.Map<List<ILeaveRequestListDto>>(leaveRequests);
        }
    }
}
