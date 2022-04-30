using AutoMapper;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.App.Features.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            LeaveRequest leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetails(request.Id);

            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}
