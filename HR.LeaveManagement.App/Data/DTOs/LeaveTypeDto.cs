namespace HR.LeaveManagement.App.Data.DTOs
{
    public interface ILeaveTypeDto
    {
        int DefaultDays { get; set; }
        string Name { get; set; }
    }

    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public int DefaultDays { get; set; }
        public string Name { get; set; }
    }
}
