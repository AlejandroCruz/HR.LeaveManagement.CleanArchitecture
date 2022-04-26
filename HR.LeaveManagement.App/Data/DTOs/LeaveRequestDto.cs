namespace HR.LeaveManagement.App.Data.DTOs
{
    public interface ILeaveRequestListDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequest { get; set; }
        public bool? Approved { get; set; }
    }
    public class LeaveRequestDto : BaseDto, ILeaveRequestListDto
    {
        public bool Cancelled { get; set; }
        public bool? Approved { get; set; }
        public DateTime? DateActioned { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; } // You don't let the DTO know about the Domain (LeaveType)
        public string RequestComments { get; set; }
    }
}
