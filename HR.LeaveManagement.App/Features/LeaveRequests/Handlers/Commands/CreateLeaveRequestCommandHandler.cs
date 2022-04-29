using AutoMapper;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.App.Features.LeaveRequests.Requests.Commands;
using HR.LeaveManagement.Domain;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

            return leaveRequest.Id;
        }
    }
}
