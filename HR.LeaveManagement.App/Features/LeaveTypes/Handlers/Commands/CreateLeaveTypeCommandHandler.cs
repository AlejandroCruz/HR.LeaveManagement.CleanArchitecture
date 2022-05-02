using AutoMapper;
using FluentValidation.Results;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.App.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.App.Features.LeaveTypes.Validators;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var valid = new CreateLeaveTypeValid();
            ValidationResult validResult = await valid.ValidateAsync(request.LeaveTypeDto);

            if (!validResult.IsValid) throw new Exception();

            LeaveType leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto); // need entity-source state?
            leaveType = await _leaveTypeRepository.Add(leaveType); // DB update

            return leaveType.Id;
        }
    }
}
