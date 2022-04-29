using AutoMapper;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.App.Features.LeaveTypes.Requests.Queries;
using HR.LeaveManagement.App.Data.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;

namespace HR.LeaveManagement.App.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<LeaveType> leaveTypes = await _leaveTypeRepository.GetAll();

            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
