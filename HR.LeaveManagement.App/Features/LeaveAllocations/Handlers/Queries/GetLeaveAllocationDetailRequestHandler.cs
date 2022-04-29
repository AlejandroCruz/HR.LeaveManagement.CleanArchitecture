using AutoMapper;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Features.LeaveAllocations.Requests.Queries;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            LeaveAllocation leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);

            return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
        }
    }
}
