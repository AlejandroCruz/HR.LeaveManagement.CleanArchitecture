using AutoMapper;
using FluentValidation;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.App.Features.LeaveAllocations.Requests.Commands;
using HR.LeaveManagement.App.Features.LeaveAllocations.Validators;
using HR.LeaveManagement.Domain;
using MediatR;
using System;

namespace HR.LeaveManagement.App.Features.LeaveAllocations.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandler(
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var valid = new CreateLeaveAllocationValid(_leaveTypeRepository);
            var validResult = await valid.ValidateAsync(request.LeaveAllocationDto);

            if (!validResult.IsValid) throw new Exception();

            var leaveAllocation = _mapper.Map<LeaveAllocation>(request.LeaveAllocationDto);
            leaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);

            return leaveAllocation.Id;
        }
    }
}
