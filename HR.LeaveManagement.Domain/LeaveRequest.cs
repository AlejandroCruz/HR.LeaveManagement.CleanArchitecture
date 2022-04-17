using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain
{
    public class LeaveRequest : BaseDomainEntity
    {
        public bool Cancelled { get; set; }
        public bool? Approved { get; set; }
        public DateTime DateActioned { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public string RequestComments { get; set; }
    }
}
