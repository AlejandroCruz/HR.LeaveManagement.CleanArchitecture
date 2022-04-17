using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.App.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveType>
    {
    }
}
