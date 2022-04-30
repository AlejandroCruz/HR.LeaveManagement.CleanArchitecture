namespace HR.LeaveManagement.App.Data.DTOs
{
    public interface ICreateLeaveTypeDto
    {
        int DefaultDays { get; set; }
        string Name { get; set; }
    }

    public class LeaveTypeDto : BaseDto, ICreateLeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
