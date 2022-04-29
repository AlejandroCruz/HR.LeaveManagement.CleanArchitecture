using AutoMapper;
using HR.LeaveManagement.App.Data.DTOs;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.App.Data.ModelProfiles
{
    public class Map : Profile
    {
        /* Automapper config */
        public Map()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
