using System;

namespace HR.LeaveManagement.App.Data.DTOs
{
    public class UpdateLeaveAllocationDto : BaseDto
    {
        int NumberOfDays { get; set; }
        int LeaveTypeId { get; set; }
        int Period { get; set; }
    }
}
