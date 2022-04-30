using AutoMapper;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.App.Features.LeaveRequests.Requests.Commands;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            Domain.LeaveRequest leaveRequest = await _leaveRequestRepository.Get(request.LeaveRequestDto.Id);

            _mapper.Map(request.LeaveRequestDto, leaveRequest);

            await _leaveRequestRepository.Update(leaveRequest);

            return Unit.Value;
        }
    }
}
