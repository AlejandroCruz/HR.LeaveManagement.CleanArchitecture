using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.App.Features.LeaveAllocations.Requests.Commands;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            Domain.LeaveAllocation leaveAllocation = await _leaveAllocationRepository.Get(request.Id);

            await _leaveAllocationRepository.Update(leaveAllocation);

            return Unit.Value;

        }
    }
}
