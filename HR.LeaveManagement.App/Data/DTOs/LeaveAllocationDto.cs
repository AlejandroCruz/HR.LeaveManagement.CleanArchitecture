namespace HR.LeaveManagement.App.Data.DTOs
{
    public interface ICreateLeaveAllocationDto
    {
        int LeaveTypeId { get; set; }
        int NumberOfDays { get; set; }
        int Period { get; set; }
    }
    public interface IUpdateLeaveAllocationDto
    {
        int LeaveTypeId { get; set; }
        int NumberOfDays { get; set; }
        int Period { get; set; }
    }

    public class LeaveAllocationDto : BaseDto,
        ICreateLeaveAllocationDto,
        IUpdateLeaveAllocationDto
    {
        public LeaveTypeDto LeaveType { get; } // You don't let the DTO know about the Domain (LeaveType)
        public int Period { get; set; }
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
