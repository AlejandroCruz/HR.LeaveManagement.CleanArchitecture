namespace HR.LeaveManagement.App.Data.DTOs
{
    public interface ILeaveRequestListDto
    {
        bool? Approved { get; set; }
        DateTime DateRequested { get; set; }
        LeaveTypeDto LeaveType { get; set; }
    }
    public interface IUpdateLeaveRequestListDto
    {
        bool Cancelled { get; set; }
        DateTime EndDate { get; set; }
        DateTime StartDate { get; set; }
        int LeaveTypeId { get; set; }
        string RequestComments { get; set; }
    }
    public interface IChangeLeaveRequestApprovalDto
    {
        bool? Approved { get; set; }
    }

    public class LeaveRequestDto :
        BaseDto,
        ILeaveRequestListDto,
        IUpdateLeaveRequestListDto,
        IChangeLeaveRequestApprovalDto
    {
        public bool Cancelled { get; set; }
        public bool? Approved { get; set; }
        public DateTime? DateActioned { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; } // You don't let the DTO know about the Domain (LeaveType)
        public string RequestComments { get; set; }
    }
}
